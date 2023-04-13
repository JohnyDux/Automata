using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostSpawner : MonoBehaviour
{
    public int numberToSpawn;
    public List<GameObject> Positions;
    public BoxCollider2D c;
    public GameObject toSpawn;

    void Update()
    {
        spawnObjects();
    }

    public void spawnObjects()
    {
        int Item;
        float screenX, screenY;
        Vector2 pos;

        for(int i = 0; i < numberToSpawn; i++)
        {
            Item = Random.Range(0, Positions.Count);

            screenX = Random.Range(c.bounds.min.x, c.bounds.max.x);
            screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
            pos = new Vector2(screenX, screenY);

            Instantiate(toSpawn, pos, toSpawn.transform.rotation);
        }
    }
}
