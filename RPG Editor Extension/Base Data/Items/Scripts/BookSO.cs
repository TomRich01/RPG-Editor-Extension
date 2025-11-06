using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "RegularBook", menuName = "Fantasy Data/Items/RegularBook", order = 4)]
public class BookSO : ItemSO
{
    
    public Chapter[] bookChapters; // Change array to List of Chapter objects
}

[System.Serializable]
public class Chapter
{
    public string title;
    [TextArea(5, 10)]
    public string[] content;
}



