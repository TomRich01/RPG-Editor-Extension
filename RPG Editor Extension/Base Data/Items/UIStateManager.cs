using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public enum UIState { Gameplay, Inventory, Smelter, Anvil }

public class UIStateManager : MonoBehaviour
{
    [SerializeField] CanvasGroup inventoryPanel;
    [SerializeField] CanvasGroup smelterPanel;
    [SerializeField] CanvasGroup anvilPanel;

    [SerializeField] PlayerInput playerInput;
    [SerializeField] float unpressGrace = 0.1f;

    UIState current = UIState.Gameplay;
    public UIState CurrentState => current;
    float cooldown;

    void Update()
    {
        if (cooldown > 0) cooldown -= Time.unscaledDeltaTime;
    }

    void Awake()
    {
        HideGroup(inventoryPanel);
        HideGroup(smelterPanel);
        HideGroup(anvilPanel);
    }

    void HideGroup(CanvasGroup g)
    {
        g.alpha = 0;
        g.blocksRaycasts = false;
        g.interactable = false;
    }


    public void Open(UIState state)
    {
        if (current == state) return;
        
        // hide previous
        SetPanelVisible(current, false);

        // show new
        current = state;
        SetPanelVisible(current, true);

        bool gameplay = current == UIState.Gameplay;
        Time.timeScale = gameplay ? 1f : 0f;
        Cursor.visible = !gameplay;
        Cursor.lockState = gameplay ? CursorLockMode.Locked : CursorLockMode.None;
        playerInput.SwitchCurrentActionMap(gameplay ? "Player" : "Menu");

        // prevent buffered clicks
        InputSystem.ResetDevice(Mouse.current);
        cooldown = unpressGrace;
    }

    void SetPanelVisible(UIState s, bool visible)
    {
        switch (s)
        {
            case UIState.Inventory: inventoryPanel.alpha = visible ? 1 : 0; inventoryPanel.blocksRaycasts = visible; inventoryPanel.interactable = true; break;
            case UIState.Smelter: smelterPanel.alpha = visible ? 1 : 0; smelterPanel.blocksRaycasts = visible; smelterPanel.interactable = true;  break;
            case UIState.Anvil: anvilPanel.alpha = visible ? 1 : 0; anvilPanel.blocksRaycasts = visible; anvilPanel.interactable = true;  break;
            case UIState.Gameplay: break; // nothing to show
        }
    }

    public void ToggleInventory()
    {
        Open(current == UIState.Inventory ? UIState.Gameplay
                                          : UIState.Inventory);
    }

    public void CloseAllUI() => Open(UIState.Gameplay);


    public bool InputBlocked => cooldown > 0f || current != UIState.Gameplay;
}

