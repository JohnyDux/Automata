using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CatchFish : MonoBehaviour
{
    public int NumberOfFish;
    public TextMeshProUGUI TextVar;

    private void Start()
    {
        NumberOfFish = 0;
    }

    private void Update()
    {
        TextVar.text = NumberOfFish.ToString();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Spawnable"))
        {
            NumberOfFish=NumberOfFish+1;
        }
    }

}
