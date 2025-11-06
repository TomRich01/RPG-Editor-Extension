using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpLevelController : MonoBehaviour
{

    [SerializeField] AnimationCurve expCurve;
    public int maxLevels = 100;
    public int startingExp = 100;

    public int currentLevel = 1;
    public int currentExp = 0;

    void Start()
    {
        StartCoroutine(AddExpPeriodically());
    }

    public void GainExp(int amount)
    {
        currentExp += amount;
        CheckForLevelUp();
    }

    private void CheckForLevelUp()
    {
        float expForCurrentLevel = expCurve.Evaluate(currentLevel);
        while (currentExp >= (int)expForCurrentLevel)
        {
            currentLevel++;
            OnLevelUp();

            // Preserve remaining XP for the next level
            currentExp -= (int)expForCurrentLevel;

            // Check for level up again in case remaining XP is enough
            expForCurrentLevel = expCurve.Evaluate(currentLevel);
        }
    }

    public virtual void OnLevelUp()
    {
        // Customize level-up logic here
       // Debug.Log("Leveled up to " + currentLevel);
    }

    IEnumerator AddExpPeriodically()
    {
        while (true)
        {
            yield return new WaitForSeconds(1.5f);
            GainExp(1000);
        }
    }

}


/*
 * [SerializeField] AnimationCurve expCurve;
    public int maxLevels = 100; // Adjust as needed
    public int startingExp = 100; // Adjust as needed, what exp is needed for first time
    public float expMultiplier = 1.2f; // Adjust as needed

    public int currentLevel = 1;
    public int currentExp = 0;
    private List<int> expRequirements;

    void Start()
    {
        expRequirements = new List<int>();
        expRequirements.Add(startingExp);

        for (int i = 1; i < maxLevels; i++)
        {
            int expForNextLevel = (int)(expRequirements[i - 1] * expMultiplier);
            expRequirements.Add(expForNextLevel);
        }
        StartCoroutine(AddExpPeriodically());
    }

    public void GainExp(int amount)
    {
        currentExp += amount;
        CheckForLevelUp();
    }

    private void CheckForLevelUp()
    {
        while (currentExp >= expRequirements[currentLevel - 1])
        {
            currentLevel++;
            currentExp -= expRequirements[currentLevel - 2]; // Subtract exp for previous level
                                                             // Add level-up effects or actions here
        }
    }

    // Event to handle level-up actions
    public virtual void OnLevelUp()
    {
        // Customize level-up logic here (e.g., UI updates, gameplay changes)
        Debug.Log("Leveled up to " + currentLevel);
    }

    IEnumerator AddExpPeriodically()
    {
        while (true)
        {
            yield return new WaitForSeconds(1.5f);
            GainExp(100); // Adjust the exp amount as needed
        }
    }
*/