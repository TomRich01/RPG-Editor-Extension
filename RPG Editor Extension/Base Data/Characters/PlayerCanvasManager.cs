using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerCanvasManager : MonoBehaviour
{
    [SerializeField] private GameObject bagSpacePanel;
   // [SerializeField] private GameObject smelterUI;
   // [SerializeField] private GameObject anvilForgeUI;
    [SerializeField] private GameObject interactCursorUI;
  //  [SerializeField] private GameObject inventoryPanel;

    [SerializeField] private TextMeshProUGUI interactionText;

    private void Awake()
    {
        HideBagSpacePanel();
      
        HideInteractCursorUI();

    }

    public void UpdateInteractionText(string text)
    {
        interactionText.text = text;
        interactionText.enabled = !string.IsNullOrEmpty(text); // Show or hide based on text presence
    }
    public void ShowBagSpacePanel()
    {
        bagSpacePanel.SetActive(true);
    }
    public void HideBagSpacePanel()
    {
        bagSpacePanel.SetActive(false);
    }
    /*
    public void ShowSmelterUI()
    {
        smelterUI.SetActive(true);
    }

    public void HideSmelterUI()
    {
        smelterUI.SetActive(false);
    }

    public void ShowAnvilForgeUI()
    {
        anvilForgeUI.SetActive(true);
    }

    public void HideAnvilForgeUI()
    {
        anvilForgeUI.SetActive(false);
    }
    */
    public void ShowInteractCursorUI()
    {
        interactCursorUI.SetActive(true);
    }

    public void HideInteractCursorUI()
    {
       interactCursorUI.SetActive(false);
    }
    /*
    public void ShowInventory()
    {
        inventoryPanel.SetActive(true);
    }

    public void HideInventory()
    {
        inventoryPanel.SetActive(false);
    }

    public bool IsInventoryVisible => inventoryPanel.activeSelf;*/
}
