using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "LifeCounter")]
public class LivesData : ScriptableObject
{
    int lifeCount = 5;
    Sprite lifeBar;

    //Decrements the life count by 1
    public void decrementLives()
    {
        lifeCount--;
    }

    //Gets the current amount of lives
    public int GetLives()
    {
        return lifeCount;
    }

    //Resets the number of lives to 5 at the start
    public void ResetLives()
    {
        lifeCount = 5;
    }
}