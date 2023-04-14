using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HammerController : MonoBehaviour
{
    Animator anim;
    public Rigidbody2D controller;
    public int HitIntensity;
    void Start()
    {
        controller = GetComponent<CharacterController>().m_Rigidbody2D;
    }
    void Update()
    {
        StartCoroutine(Wait(anim, controller));
    }

    IEnumerator Wait(Animator anim, Rigidbody2D controller)
    {
        anim.SetBool("Hit", true);
        controller.AddForce(Vector2.up*HitIntensity);
        yield return new WaitForSeconds(2);
        anim.SetBool("Hit", false);
    }
}
