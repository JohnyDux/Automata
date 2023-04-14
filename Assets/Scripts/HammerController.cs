using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HammerController : MonoBehaviour
{
    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        StartCoroutine(Wait(anim));
    }

    IEnumerator Wait(Animator anim)
    {
        anim.SetBool("Hit", true);
        yield return new WaitForSecondsRealtime(2);
        anim.SetBool("Hit", false);
    }
}
