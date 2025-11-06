using UnityEngine;

public class Interact : MonoBehaviour
{
    [Header("Raycast")]
    [SerializeField] private float interactionDistance = 3f;
    [SerializeField] private LayerMask interactableLayer = ~0;

    [Header("Dependencies")]
    [SerializeField] private PlayerController playerController;
    [SerializeField] private PlayerCanvasManager playerCanvasManager;
    [SerializeField] private Camera mainCam;

    private InputReader inputReader;
    private IInteractable currentInteractable;

    // UI state is tied to *the object currently hovered*.
    private bool isUIOpen;

    private float lastInteractTime;
    private const float interactCooldown = 0.2f;

    #region Unity lifecycle

    private void Awake()
    {
        // Inspector fallbacks
        if (!playerController) playerController = GetComponent<PlayerController>();
        if (!playerCanvasManager) playerCanvasManager = GetComponentInChildren<PlayerCanvasManager>();
        if (!mainCam) mainCam = GetComponentInChildren<Camera>();

        inputReader = playerController.InputReader;
    }

    private void OnEnable()
    {
        inputReader.InteractEvent += HandleInteract;
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void OnDisable()
    {
        inputReader.InteractEvent -= HandleInteract;
    }

    private void Update()
    {
        UpdateHover();
    }

    #endregion 

    #region Hover logic

    private void UpdateHover()
    {
        Ray ray = mainCam.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(ray.origin, ray.direction * interactionDistance, Color.green);

        if (Physics.Raycast(ray, out var hit, interactionDistance, interactableLayer, QueryTriggerInteraction.Ignore) &&
            hit.collider.TryGetComponent<IInteractable>(out var interactable))
        {
            // Switched to a *new* interactable – reset UI state so first click always "opens".
            if (currentInteractable != interactable)
            {
                currentInteractable = interactable;
                isUIOpen = false;
            }

            playerCanvasManager.ShowInteractCursorUI();
            playerCanvasManager.UpdateInteractionText(interactable.GetInteractionText());
        }
        else
        {
            currentInteractable = null;
            playerCanvasManager.HideInteractCursorUI();
            playerCanvasManager.UpdateInteractionText(string.Empty);
        }
    }

    #endregion

    #region Interaction logic

    private void HandleInteract()
    {
        if (currentInteractable == null) return;
        if (Time.time - lastInteractTime < interactCooldown) return;

        lastInteractTime = Time.time;

        isUIOpen = !isUIOpen;             // decide *first*
        currentInteractable.Interact();   // let the interactable do its thing

        Debug.Log($"Interacting with {currentInteractable} – UI {(isUIOpen ? "Opened" : "Closed")}");
    }

    #endregion
}



