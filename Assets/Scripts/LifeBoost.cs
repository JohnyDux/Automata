using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeBoost : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public int PlusLife;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            playerHealth.TakeDamage(-PlusLife);
        }

        Destroy(this.gameObject);
    }
}
