using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="CoinCounter")]
public class CoinData : ScriptableObject
{
    public int count = 20;

    public void decrementCount()
    {
        count--;
    }

    public int getCount()
    {
        return count;
    }
}
