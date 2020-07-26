using UnityEngine;

[CreateAssetMenu(fileName = "RegularBook", menuName = "Fantasy Data/Items/RegularBook", order = 4)]
public class CreateRegularBookEditor : ScriptableObject
{
    public string bookId;
    public string bookName;
    [TextArea]
    public string bookDescription;
    [TextArea]
    public string[] bookChapters;
    [Space(10)]
    public int bookValue;
    public float bookWeight;
    [Space(10)]
    public AudioClip useSound;
    public AudioClip pickupSound;
    public AudioClip putdownSound;
    [Space(10)]
    public GameObject bookModel;
    
  }
        
       
        
    

    // need to figure out the book system first.


