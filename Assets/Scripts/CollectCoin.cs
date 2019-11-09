using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    public CoinData c;
    
    // Start is called before the first frame update
    void Start()
    {
        //Calls the reset coin function
        c.ResetCount();
    }

    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        GameObject g = col.gameObject;
        if (g.CompareTag("Coin"))
        {
            //Destroys the coin object
            GameObject.Destroy(g);

            //Calls the decrement coin function
            c.decrementCount();
        }
    }
}
