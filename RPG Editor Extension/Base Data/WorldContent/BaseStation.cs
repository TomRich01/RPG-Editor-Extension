using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Crafting.Stations
{
    public class BaseStation : MonoBehaviour, IInteractable
    {

        [SerializeField] UIStateManager ui;

        [SerializeField] private string stationName;
        public string StationName { get => stationName; }

        enum StationType { 
            Smelter, 
            Anvil 
        }
        [SerializeField] StationType stationType;

        readonly List<PlayerController> playersInRange = new();

        void Awake() => ui = FindObjectOfType<UIStateManager>();

        /* ---------- Trigger handling ---------- */

        void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out PlayerController pc))
                playersInRange.Add(pc);
        }

        void OnTriggerExit(Collider other)
        {
            if (other.TryGetComponent(out PlayerController pc))
            {
                playersInRange.Remove(pc);

                // If the leaving player was using this station, close its UI
                if (playersInRange.Count == 0 && StationUIIsOpen())
                    ui.CloseAllUI();
            }
        }

        /* ---------- Interaction ---------- */

        public void Interact()
        {
            if (playersInRange.Count == 0) return;      // safety

            switch (stationType)
            {
                case StationType.Smelter: ui.Open(UIState.Smelter); break;
                case StationType.Anvil: ui.Open(UIState.Anvil); break;
            }
        }

        /* ---------- Helper ---------- */

        bool StationUIIsOpen() =>
            ui.CurrentState == UIState.Smelter && stationType == StationType.Smelter
         || ui.CurrentState == UIState.Anvil && stationType == StationType.Anvil;

        private void OnDrawGizmos()
        {
            // Set gizmo color with semi-opaque color (e.g., red with 50% opacity)
            Gizmos.color = new Color(0f, 1f, 0f, 0.5f); // Red with 50% opacity

            // Get the SphereCollider component and draw a sphere gizmo to match the collider
            SphereCollider sphereCollider = GetComponent<SphereCollider>();
            if (sphereCollider != null)
            {
                // Use the collider's position, center, and radius
                Gizmos.DrawSphere(transform.position + sphereCollider.center, sphereCollider.radius);
            }
        }

        public string GetInteractionText()
        {
            return $"Use {stationName}";
        }
    }
}
