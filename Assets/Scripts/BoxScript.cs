using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BoxScript : MonoBehaviour
{
    public GameObject Fish_Prefab;
    public GameObject Spawn_Position;

    public CatchFish ref_script;
    public int num_fish;

    public TextMeshPro textObject;

    private void Start()
    {
        num_fish = 0;
    }

    private void Update()
    {
        Fish_Prefab.gameObject.SetActive(false);
        textObject.text = num_fish.ToString();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            num_fish = num_fish + ref_script.NumberOfFish;
            ref_script.NumberOfFish = 0;
        }
    }
}
