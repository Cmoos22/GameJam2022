using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class CoinCounter : MonoBehaviour
{
    public TextMeshProUGUI text;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
    }
    // Update is called once per frame
    void Update()
    {
        //Set the current number of coins to display
        if (text.text != Coin.totalCoins.ToString())
        {
            text.text = Coin.totalCoins.ToString();
        }
    }

}

