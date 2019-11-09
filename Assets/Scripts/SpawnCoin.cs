using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCoin : MonoBehaviour
{
    public GameObject coinPrefab;
    public CoinData c;
    public float x;
    private float y = -2.5f;
    private Vector3 coinPosition;

    // Start is called before the first frame update
    void Start()
    {
        //Calls the function to spawn the coins at the start
        for (int i = 0; i < 20; i++)
        {
            SpawnCoins();
        }
    }

    void Update()
    {
        
    }

    void SpawnCoins()
    {
        //Sets range for coins to spawn in
        x = Random.Range(-5.5f, 5.5f);

        //Sets position for the coins to spawn at
        coinPosition = new Vector3(x, y, 0);

        //Spawns the coins
        Instantiate(coinPrefab, coinPosition, Quaternion.identity);
    }
}
