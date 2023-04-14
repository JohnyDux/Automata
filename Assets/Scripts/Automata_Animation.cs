using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Automata_Animation : MonoBehaviour
{
	public bool IsEnraged;
	public int HitCount;
	public int damage;
	public PlayerHealth playerHealth;
	Animator AutomataAnimator;
	public GameObject Drill;

    void Start()
	{
		AutomataAnimator = GetComponent<Animator>();
		Drill.SetActive(false);

		HitCount = 0;
	}

    void Update()
    {
		AutomataAnimator.SetBool("IsWalking", true);
		Drill.SetActive(true);

		if (HitCount > 2)
		{
			IsEnraged = true;
		}

		if(HitCount < 0)
        {
			HitCount = 0;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
		if (collision.gameObject.tag == "Player")
			HitCount ++;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            if (IsEnraged)
            {
				AutomataAnimator.SetBool("Attack", false);
				playerHealth.TakeDamage(damage*2);

				Debug.Log("Enraged Attack");
			}
            if (!IsEnraged)
            {
				AutomataAnimator.SetBool("Attack", true);
				playerHealth.TakeDamage(damage);

				Debug.Log("Normal Attack");
			}
		}
    }

	private void OnTriggerExit2D(Collider2D collision)
	{
		if (collision.gameObject.tag == "Player")
        {
			AutomataAnimator.SetBool("Attack", false);
		}
	}
}
