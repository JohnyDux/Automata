using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public CharacterController controller;

	public float runSpeed = 40f;

	public float horizontalMove = 0f;
	bool jump = false;
	bool crouch = false;
	public Animator animator;

	void Update()
	{
		horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

		animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

		if (Input.GetKeyDown("w"))
		{
			jump = true;
		}

		if (Input.GetKeyDown(KeyCode.LeftShift))
		{
			crouch = true;
		}
		else if (Input.GetKeyUp(KeyCode.LeftShift))
		{
			crouch = false;
		}

		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;

	}

	void FixedUpdate()
	{
		controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
		jump = false;
	}
}