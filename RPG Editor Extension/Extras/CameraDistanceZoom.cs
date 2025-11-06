using Cinemachine;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class CameraDistanceZoom : MonoBehaviour
{
    [Header("Refs")]
    public CinemachineVirtualCamera vcam;
    public SkinnedMeshRenderer headRenderer;     // hide in FP
    public SkinnedMeshRenderer armRenderer;     // hide in TP
    Cinemachine3rdPersonFollow tpf;

    [Header("Zoom")]
    public float min = 0.0f;
    public float max = 5.0f;
    public float stepPerTick = 0.9f;             // how much one wheel "tick" moves the target
    public float smoothTime = 0.12f;             // SmoothDamp time
    public float deadzone = 0.01f;               // ignore tiny scroll noise

    [Header("First-person blend")]
    public float fpThreshold = 0.12f;            // <= becomes FP
    public Vector3 thirdPersonShoulder = new(0.35f, 0.2f, 0);
    public float shoulderLerpSpeed = 12f;

    float target;     // desired distance
    float vel;        // SmoothDamp velocity holder

    void Awake()
    {
        tpf = vcam.GetCinemachineComponent<Cinemachine3rdPersonFollow>();
        target = tpf.CameraDistance;
    }

    void Update()
    {
        // 1) Read scroll safely
        float scroll = 0f;
#if ENABLE_INPUT_SYSTEM
        if (Mouse.current != null) scroll = Mouse.current.scroll.ReadValue().y / 120f;
#else
        scroll = Input.mouseScrollDelta.y;
#endif

        // Optional: block when over UI
        if (EventSystem.current != null && EventSystem.current.IsPointerOverGameObject())
            scroll = 0f;

        // 2) Update target distance (don’t set the camera yet)
        if (Mathf.Abs(scroll) > deadzone)
        {
            target = Mathf.Clamp(target - Mathf.Sign(scroll) * stepPerTick, min, max);
        }

        // 3) Smooth toward target
        tpf.CameraDistance = Mathf.SmoothDamp(tpf.CameraDistance, target, ref vel, smoothTime);

        // 4) FP/3P blending niceties
        bool firstPerson = tpf.CameraDistance <= fpThreshold;

        // Shoulder offset eases toward zero in FP
        var desiredShoulder = firstPerson ? Vector3.zero : thirdPersonShoulder;
        tpf.ShoulderOffset = Vector3.Lerp(tpf.ShoulderOffset, desiredShoulder, shoulderLerpSpeed * Time.deltaTime);

        // Hide head in FP
        if (headRenderer) headRenderer.enabled = !firstPerson;
        if (armRenderer) armRenderer.enabled = firstPerson;
    }
}