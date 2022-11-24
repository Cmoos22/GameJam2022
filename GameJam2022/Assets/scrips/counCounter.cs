using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class counCounter : MonoBehaviour
{
    Text counterText;

    void Start()
    {
        counterText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        //Set the current number of coins to display
        if (counterText.text != Coin.totalCoins.ToString())
        {
            counterText.text = Coin.totalCoins.ToString();
        }
    }
}
