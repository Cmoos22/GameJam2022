# GameJam2022
gruppe 8 GameJam
Coin 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_2DCoin : MonoBehaviour
{
    //Keep track of total picked coins (Since the value is static, it can be accessed at "SC_2DCoin.totalCoins" from any script)
    public static int totalCoins = 0;

    void Awake()
    {
        //Make Collider2D as trigger 
        GetComponent<Collider2D>().isTrigger = true;
    }

    void OnTriggerEnter2D(Collider2D c2d)
    {
        //Destroy the coin if Object tagged Player comes in contact with it
        if (c2d.CompareTag("Player"))
        {
            //Add coin to counter
            totalCoins++;
            //Test: Print total number of coins
            Debug.Log("You currently have " + SC_2DCoin.totalCoins + " Coins.");
            //Destroy coin
            Destroy(gameObject);
        }
    }
}


Coin Counter
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SC_CoinCounter : MonoBehaviour
{
    Text counterText;

    // Start is called before the first frame update
    void Start()
    {
        counterText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        //Set the current number of coins to display
        if (counterText.text != SC_2DCoin.totalCoins.ToString())
        {
            counterText.text = SC_2DCoin.totalCoins.ToString();
        }
    }
}

Source for both Scripts = https://sharpcoderblog.com/blog/unity-2d-coin-pickup










scripted for cam movement para-something

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    public Camera cam;
    public Transform subject;

    Vector2 startPosistion;
    float startZ;
    // poperties teat like valubles for everyTime we cauculate
    // => means can only be set here

    // the position cam has moved from org player pos
    Vector2 travel => (Vector2)cam.transform.position - startPosistion;

    float distanceFromSubject => transform.position.z - subject.position.z;
    float clippingplane => (cam.transform.position.z + (distanceFromSubject > 0? cam.farClipPlane : cam.nearClipPlane ));

    float parallaxFactor => Mathf.Abs(distanceFromSubject) / clippingplane;

    // Start is called before the first frame update
    public void Start()
    {
        startPosistion = transform.position;
        startZ = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
       Vector2 newpos = transform.position = startPosistion * travel;
        transform.position = new Vector3(newpos.x, newpos.y, startZ);

    }
}
