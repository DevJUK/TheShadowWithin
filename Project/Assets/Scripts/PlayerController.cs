﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour
{
	public Sprite IdleSide;
	public float RayLenght;

	private bool IsPlayer;
	private bool WasLastLeft;
	private GameController Controller;
	private Animator Anim;
	private SpriteRenderer SR;

	[Header("Raycasting Elements")]
	public GraphicRaycaster Ray;
	public PointerEventData PointerEvent;
	public EventSystem Events;


	private void Start()
	{
		Controller = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
		Anim = GetComponent<Animator>();
		SR = GetComponent<SpriteRenderer>();

		if (gameObject.name == "Player")
		{
			IsPlayer = true;
		}
	}

	private void Update()
	{
		PointerEvent = new PointerEventData(Events);                        // Set up a new PointerEvent
		PointerEvent.position = Input.mousePosition;                        // Set up the PointerEvent to be where the mouse is
		List<RaycastResult> Results = new List<RaycastResult>();            // Creating a list to store the raycase information
		Ray.Raycast(PointerEvent, Results);

		Debug.DrawLine(transform.position, transform.position + new Vector3(0, RayLenght, 0), Color.white);

		if (Input.GetMouseButtonDown(0))                                    // If right click is pressed
		{
			foreach (RaycastResult Hit in Results)
			{
				if (Hit.gameObject.name == "UpButton")
				{
					foreach (Rigidbody2D I in Controller.RBs)
					{
						if (Physics2D.Linecast(transform.position, transform.position + new Vector3(0, RayLenght, 0), 1 << LayerMask.NameToLayer("Land")))
						{
							I.AddForce(Vector2.up * Controller.JumpHeight);
						}


					}
				}



				if (Hit.gameObject.name == "LeftButton")
				{
					foreach (Rigidbody2D I in Controller.RBs)
					{
						I.velocity = Vector2.left * Controller.MoveSpeed;
						Anim.SetBool("IsMoving", true);
						SR.flipX = false;
						WasLastLeft = true;
					}
				}
				else if (Hit.gameObject.name == "RightButton")
				{
					foreach (Rigidbody2D I in Controller.RBs)
					{
						I.velocity = Vector2.right * Controller.MoveSpeed;
						Anim.SetBool("IsMoving", true);
						SR.flipX = true;
						WasLastLeft = false;

					}
				}
			}
		}
		
		if (Input.GetMouseButtonUp(0))
		{
			foreach (Rigidbody2D I in Controller.RBs)
			{
				I.velocity = Vector2.zero;
				Anim.SetBool("IsMoving", false);

				if (WasLastLeft)
				{
					SR.flipX = false;
					SR.sprite = IdleSide;
				}
				else
				{
					SR.flipX = true;
					SR.sprite = IdleSide;
				}
			}
		}
	}


	public void AndroidControls()               // Android controls for the game
	{
		if (Input.touchCount == 1)
		{
			if (Input.GetTouch(0).phase == TouchPhase.Began)
			{
				var Touch = TouchPos();

				if (Touch)
				{

				}
			}

			if (Input.GetTouch(0).phase == TouchPhase.Ended)
			{
				foreach (Rigidbody2D I in Controller.RBs)
				{
					I.velocity = Vector2.zero;
				}
			}
		}
	}

	public Collider2D TouchPos()                // gets the touch position in the game
	{
		Vector3 V3Pos = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
		Vector2 Pos = new Vector2(V3Pos.x, V3Pos.y);

		var Hit = Physics2D.OverlapPoint(Pos);

		return Hit;     // returns the hit object
	}



	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (IsPlayer)
		{
			if (collision.gameObject.tag == "Emilies")
			{
				gameObject.SetActive(false);
			}
		}
	}
}
