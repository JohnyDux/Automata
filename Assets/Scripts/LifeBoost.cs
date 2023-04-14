using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeBoost : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerHealth GO;

        if(collision.CompareTag("Player"))
        {
            GO = collision.gameObject.GetComponent<PlayerHealth>();

            if (GO.health < 1500)
            {
                int diference = 1500 - GO.health;
                GO.TakeDamage(-diference);
                Destroy(gameObject);
            }
        }
    }
}
