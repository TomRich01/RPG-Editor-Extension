using UnityEditor;
using UnityEngine;
using UnityEngine.Rendering;

[CreateAssetMenu(fileName = "Race", menuName = "Fantasy Data/Character/Race", order = 2)]
public class CreateRaceEditor : ScriptableObject
{
    
    public string raceId;
    public string raceName;
    [Space(10)]
    [TextArea]
    public string raceDescription;


    
  

}