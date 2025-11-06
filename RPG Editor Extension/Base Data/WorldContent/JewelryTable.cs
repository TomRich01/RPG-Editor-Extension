using System.Collections;
using System.Collections.Generic;
using TMPro;
using TMPro.EditorUtilities;
using UnityEngine;

namespace Crafting.Stations
{
    public class JewelryTable : MonoBehaviour, IInteractable
    {
        [SerializeField] private bool isDisplayShown;

        [SerializeField] private List<GameObject> playerControllers = new List<GameObject>();
        private SphereCollider sphereCollider;
        private void Start()
        {
            sphereCollider = GetComponent<SphereCollider>();

        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.GetComponent<PlayerController>())
            {
                playerControllers.Add(other.gameObject);
                isDisplayShown = false;
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.gameObject.GetComponent<PlayerController>())
            {
                isDisplayShown = false;
                playerControllers[0].GetComponentInChildren<PlayerCanvasManager>().HideBagSpacePanel();
                playerControllers.Remove(other.gameObject);
            }
        }
        public void Interact()
        {
            if (playerControllers.Count > 0)
            {
                isDisplayShown = !isDisplayShown;

                if (isDisplayShown)
                {
                    playerControllers[0].GetComponentInChildren<PlayerCanvasManager>().ShowBagSpacePanel();
                }
                else
                {
                    playerControllers[0].GetComponentInChildren<PlayerCanvasManager>().HideBagSpacePanel();
                }
            }

        }

        public string GetInteractionText()
        {
            throw new System.NotImplementedException();
        }
    }

}
