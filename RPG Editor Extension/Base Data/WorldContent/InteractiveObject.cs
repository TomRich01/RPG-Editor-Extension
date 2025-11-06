using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveObject : MonoBehaviour, IInteractable
{
    public string GetInteractionText()
    {
        throw new System.NotImplementedException();
    }

    public void Interact()
    {
        Debug.Log("Interacted");
        
    }
}
