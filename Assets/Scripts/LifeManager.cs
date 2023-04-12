using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeManager : MonoBehaviour
{
    public GameObject LifeUI;

    PlayerHealth Player;

    int health;

    RectTransform rt;
    void Start()
    {
        rt = LifeUI.GetComponent(typeof(RectTransform)) as RectTransform;
        Player = GetComponent<PlayerHealth>();
    }
    void Update()
    {
        health = Player.health;
        rt.sizeDelta = new Vector2(0, health);
    }
}
