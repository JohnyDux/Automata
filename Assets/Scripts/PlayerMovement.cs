using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerMovement : MonoBehaviour
{
	public CharacterController controller;

	public float walkSpeed;

	public bool IsRunning;

	public float horizontalMove = 0f;
	bool jump = false;
	bool crouch = false;
	public Animator animator;

	public TextMeshProUGUI speedText;

    private void Start()
    {
		walkSpeed = 5f;
	}

    private void Update()
	{
		horizontalMove = Input.GetAxisRaw("Horizontal") * walkSpeed;

		if (Input.GetKeyDown("r"))
        {
			if(IsRunning == false)
            {
				speedText.color = Color.green;
				walkSpeed = 10f;
				IsRunning = true;
			}
			else if (IsRunning == true)
			{
				speedText.color = Color.white;
				walkSpeed = 5f;
				IsRunning = false;
			}
		}

		animator.SetFloat("Speed", Mathf.Abs(horizontalMove * walkSpeed));

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

		//Cursor.lockState = CursorLockMode.Confined;
		//Cursor.visible = true;

	}

	void FixedUpdate()
	{
		controller.Move(horizontalMove * walkSpeed * Time.fixedDeltaTime, crouch, jump);
		jump = false;
	}
}