using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class CreatePathAreaWizard : ScriptableWizard
{


    [MenuItem("GameObject/Create Path Point Wizard")]
    static void CreateWizard()
    {
        ScriptableWizard.DisplayWizard<CreatePathAreaWizard>("Create Path Point", "Create", "Apply");
        //If you don't want to use the secondary button simply leave it out:
        //ScriptableWizard.DisplayWizard<WizardCreateLight>("Create Light", "Create");
    }

    void OnWizardCreate()
    {
        GameObject go = new GameObject("New Path Point");
        go.AddComponent<boxgiz>();
        // Draw a semitransparent blue cube at the transforms position
        
    }


    void OnWizardUpdate()
    {
        helpString = "Please create a path point";
    }

    // When the user presses the "Apply" button OnWizardOtherButton is called.
 

}