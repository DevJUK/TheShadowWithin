using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public enum Buttons
	{
		Left,
		Right,
		Up,
	};

	public Buttons Button;

	public float MoveSpeed;
	public bool IsFacingRight;

	private Rigidbody2D RB;

	private void Start()
	{
		RB = GetComponent<Rigidbody2D>();
	}


	private void Update()
	{
		ButtonController();
	}


	private void LeftMove()
	{
		RB.velocity += Vector2.left * MoveSpeed;
		IsFacingRight = false;
	}


	private void RightMove()
	{
		RB.velocity += Vector2.right * MoveSpeed;
		IsFacingRight = true;
	}

	private void ButtonController()
	{
		switch (Button)
		{
			case Buttons.Left:
				LeftMove();
				break;
			case Buttons.Right:
				RightMove();
				break;
			case Buttons.Up:

				break;
			default:
				break;
		}
	}

	public void ChangeState(Buttons Input)
	{
		Button = Input;
	}
}
