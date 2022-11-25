using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpJump : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        PlayerMovement player = other.transform.GetComponent<PlayerMovement>();
        if (other.gameObject.CompareTag("Player"))
        {
            player.PowerJumpEnabled();
            Destroy(this.gameObject);
        }
    }
}
