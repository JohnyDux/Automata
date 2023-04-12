using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeManager : MonoBehaviour
{
    public PlayerHealth playerHealth;

    public Slider rt;

    void Start()
    {
        rt.value = 100;
    }
    void Update()
    {
        rt.value = playerHealth.health;
    }
}
