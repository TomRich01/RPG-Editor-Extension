using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class LoreLoader : MonoBehaviour
{
   public LoreMaker [] lore;
    public LoreMaker loreMaker;

    public Transform loadModelArea;
    public GameObject model;
    public GameObject instantModel;


    public TMP_Text text;
    // Start is called before the first frame update

    private void Awake()
    {
        loreMaker = lore[Random.Range(0, lore.Length)];
        model = loreMaker.screenModel;
    }
    void Start()
    {
      
       instantModel = GameObject.Instantiate(model, loadModelArea);
        instantModel.transform.SetParent(null);
        text.text = loreMaker.screenText;
    }


   
    // Update is called once per frame
    void Update()
    {
        

        
        
    }

    
}