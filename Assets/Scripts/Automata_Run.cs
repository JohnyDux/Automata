using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Automata_Run : MonoBehaviour
{
	public float speed = 2.5f;
	public float attackRange = 3f;
	public float distanceBetween = 1f;

	public int damadge;

	private float distance;

	Transform player;
	public PlayerHealth playerHealth;
	Rigidbody2D rb;
	Automata boss;
	Animator animator;

	void Start()
	{
		player = GameObject.FindGameObjectWithTag("Player").transform;
		rb = GetComponent<Rigidbody2D>();
		animator = GetComponent<Animator>();
		boss = GetComponent<Automata>();
	}

	void Update()
	{
		boss.LookAtPlayer();

		Vector2 target = new Vector2(player.position.x, rb.position.y);
		Vector2 newPos = Vector2.MoveTowards(rb.position, target, speed * Time.fixedDeltaTime);
		rb.MovePosition(newPos);
	}

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
			Debug.Log("Player Life: " + playerHealth.health);
			animator.SetBool("Attack", true);
			playerHealth.TakeDamage(damadge);
		}
    }

	private void OnTriggerExit2D(Collider2D collision)
	{
		animator.SetBool("Attack", false);
	}
}
