using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinDisplay : MonoBehaviour
{
    public CoinData c;
    public Text coinText;

    // Start is called before the first frame update
    void Start()
    {
        //Gets the text component
        coinText = GetComponent<Text>();
    }

    void Update()
    {
        //Checks to see if the player has gotten all the coins
        if (c.GetCount() == 0)
        {
            coinText.text = "You win!";
        }
        else
        {
            coinText.text = "Coins Left: " + c.GetCount().ToString();
        }
    }
}
