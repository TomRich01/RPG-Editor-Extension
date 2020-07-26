using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DoorBehavior : MonoBehaviour
{

    /*The code below is for demonstration only. It must be refactored for an inventory. The key directly lines up with the door and does
      not pull from the inventory as it would on a normal game.*/

    [SerializeField] string doorName;
    [SerializeField] KeyItem key;
    // [SerializeField] AnimationClip doorOpen;
    // [SerializeField] AnimationClip doorClose;
    public Animator anim;
    [SerializeField] bool hasKey;
    [SerializeField] bool leadsToScene;
    [SerializeField] string doorToScene;
    public Text textMesh;
    private string Locked = " (Locked)";

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnMouseOver()
    {
        if (FindObjectOfType<DoorBehavior>())
        {
            if (doorName != null)
            {
                if (key)
                {
                    textMesh.gameObject.SetActive(true);
                    textMesh.text = doorName + Locked;
                    anim.SetBool("isLocked", true);

                    if (key.keyItem.keyName != "Key to " + doorName)
                    {
                        textMesh.gameObject.SetActive(true);
                        textMesh.text = doorName + " Wrong Key";
                        anim.SetBool("isLocked", true);
                    }

                    if (key.keyItem.keyName == "Key to " + doorName)
                    {
                        textMesh.gameObject.SetActive(true);
                        textMesh.text = doorName + " (Unlocked)";
                        anim.SetBool("isLocked", false);
                    }
                }
                if (key == null)
                {
                    textMesh.gameObject.SetActive(true);
                    textMesh.text = "You do not have a key";
                    anim.SetBool("isLocked", true);
                }
                
                
            }
           



        }
     

    }

    private void OnMouseExit()
    {
        textMesh.gameObject.SetActive(false);
    }


    // Update is called once per frame
    void Update()
    {
       
    }
}
