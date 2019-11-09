using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="CoinCounter")]
public class CoinData : ScriptableObject
{
    //set coin amount to 20
    int coinCount = 20;

    //Decrement the coin count by 1
    public void decrementCount()
    {
        coinCount--;
    }

    //Gets the current coin count
    public int GetCount()
    {
        return coinCount;
    }

    //Resets the coin count to 20 each start
    public void ResetCount()
    {
        coinCount = 20;
    }
}
