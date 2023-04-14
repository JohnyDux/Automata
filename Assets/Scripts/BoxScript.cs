using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxScript : MonoBehaviour
{
    public GameObject Fish_Prefab;
    public GameObject Spawn_Position;
    Vector3 offset = new Vector2(1,0);

    CatchFish ref_script;

    private void Start()
    {
        ref_script = GetComponent<CatchFish>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            ref_script.NumberOfFish = 0;
            //Instantiate(Fish_Prefab, Spawn_Position.transform.position + offset, );
        }
    }
}
