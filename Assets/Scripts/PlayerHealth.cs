using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
	public int health;

	public bool invincibility;

	public TextMeshProUGUI invincibilityText;

	public GameObject deathEffect;

	public bool IsAttacking;

    private void Start()
    {
		IsAttacking = false;
		health = 1500;
	}

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && invincibility == false)
		{
			invincibility = true;
			invincibilityText.color = Color.green;
        }
		else if (Input.GetKeyDown(KeyCode.F) && invincibility == true)
		{
			invincibility = false;
			invincibilityText.color = Color.white;
		}
	}

    public void TakeDamage(int damage)
	{
		IsAttacking = true;

		if (invincibility == false)
		{
			health = health - damage;

			StartCoroutine(DamageAnimation());

			if (health <= 0)
			{
				Die();
			}
		}
        else
        {
			health = 1500;
        }
	}

	void Die()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}

	IEnumerator DamageAnimation()
	{
		SpriteRenderer[] srs = GetComponentsInChildren<SpriteRenderer>();

		for (int i = 0; i < 3; i++)
		{
			foreach (SpriteRenderer sr in srs)
			{
				Color c = sr.color;
				c.a = 0;
				sr.color = c;
			}

			yield return new WaitForSeconds(.1f);

			foreach (SpriteRenderer sr in srs)
			{
				Color c = sr.color;
				c.a = 1;
				sr.color = c;
			}

			yield return new WaitForSeconds(.1f);
		}
	}
}
