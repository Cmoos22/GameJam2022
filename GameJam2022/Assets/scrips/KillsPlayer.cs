using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillsPlayer : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(collision.gameObject,0.3f);

            Debug.Log(collision.gameObject.name);
        }
    }

 
}
