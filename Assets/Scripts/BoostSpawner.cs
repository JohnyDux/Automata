using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostSpawner : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public int AmountToSpawn;
    public List<GameObject> Positions;
    Transform SpawnPosition;
    public BoxCollider2D c;
    public GameObject toSpawn;

    List<Transform> Points;

    [Header("Intervals of spawning(in seconds)")]
    public float spawnRate;

    void Start()
    {
        InvokeRepeating("spawnObjects", 0, spawnRate);
        Instantiate(toSpawn, Positions[Random.Range(0, Positions.Count)].transform);

        playerHealth = GetComponent<PlayerHealth>();
    }

    void Update()
    {
        SpawnPosition  = Positions[Random.Range(0, Positions.Count)].transform;
    }
    public void spawnObjects()
    {
        Instantiate(toSpawn, SpawnPosition);
    }
}
