using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using JetBrains.Annotations;

public class InteractmarkerWizard : ScriptableWizard
{
    public string Name;

    [MenuItem("GameObject/Create Interaction Marker")]

    
    static void CreateWizard()
    {
        ScriptableWizard.DisplayWizard<InteractmarkerWizard>("Create Interaction Marker", "Create");
        
        //If you don't want to use the secondary button simply leave it out:
        //ScriptableWizard.DisplayWizard<WizardCreateLight>("Create Light", "Create");
    }

    void OnWizardCreate()
    {
        GameObject go = new GameObject("New Interact Marker");
        go.name = Name;
        go.AddComponent<InteractionBox>();
        // Draw a semitransparent blue cube at the transforms position

    }


    void OnWizardUpdate()
    {
        helpString = "Please create an interaction marker box";
    }

    // When the user presses the "Apply" button OnWizardOtherButton is called.


}