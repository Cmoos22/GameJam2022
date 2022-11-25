using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
// part of code soursed : https://sharpcoderblog.com/blog/unity-2d-coin-pickup
public class EndCoinProsession : MonoBehaviour
{
    public string EndScene = "End scene";
    void Awake()
    {
        //Make Collider2D as trigger 
        GetComponent<Collider2D>().isTrigger = true;
    }
    void OnTriggerEnter2D(Collider2D endC)
    {
        //Destroy the coin if Object tagged Player comes in contact with it
        if (endC.CompareTag("Player"))
        {
            Debug.Log("you finnished! ");
            Destroy(gameObject, 0.5f);

            FindObjectOfType<TimeManager>().LoadScene(EndScene);
        }
    }



}
