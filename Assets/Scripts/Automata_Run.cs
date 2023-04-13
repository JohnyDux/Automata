using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Automata_Run : MonoBehaviour
{
	public float speed = 2.5f;
	public float attackRange = 3f;
	public float distanceBetween = 1f;

	public int damage;

	public float distance;

	GameObject player;
	public PlayerHealth playerHealth;
	Animator animator;

	void Start()
	{
		player = GameObject.FindGameObjectWithTag("Player");
		animator = GetComponent<Animator>();
	}

    void Update()
    {
		distance = Vector2.Distance(transform.position, player.transform.position);
		Vector2 direction = player.transform.position - transform.position;
		direction.Normalize();
		transform.position = Vector2.MoveTowards(transform.position, player.transform.position, attackRange);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
			animator.SetBool("Attack", true);
			playerHealth.TakeDamage(damage);
		}
    }

	private void OnTriggerExit2D(Collider2D collision)
	{
		animator.SetBool("Attack", false);
	}
}
