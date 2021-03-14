using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace CarterGames.TheShadowWithin
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private float moveSpd;
        [SerializeField] private float jumpHeight;

        private Rigidbody2D rb;
        private BoxCollider2D box;
        private Actions inputActions;
        [SerializeField] private bool shouldMove;
        [SerializeField] private bool jumpPressed;
        [SerializeField] private Transform feet;
        [SerializeField] private float rad;
        [SerializeField] private LayerMask mask;
        private float jumpTimeCount;
        public float jumpTime;
        public bool isJumping;
        

        private void OnEnable()
        {
            inputActions = new Actions();
            inputActions.Platformer.Move.started += CanMovement;
            inputActions.Platformer.Move.canceled += StopMovement;
            inputActions.Platformer.Jump.started += JumpPress;
            inputActions.Platformer.Jump.canceled += JumpRelease;
            inputActions.Enable();
        }


        private void OnDisable()
        {
            inputActions.Disable();
        }


        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
            box = GetComponent<BoxCollider2D>();
        }

        
        private void CanMovement(InputAction.CallbackContext ctx)
        {
            if (!shouldMove)
                shouldMove = true;
        }
        
        private void StopMovement(InputAction.CallbackContext ctx)
        {
            if (shouldMove)
                shouldMove = false;
        }


        private void JumpPress(InputAction.CallbackContext ctx)
        {
            jumpPressed = true;
        }
        
        private void JumpRelease(InputAction.CallbackContext ctx)
        {
            jumpPressed = false;
            isJumping = false;
        }


        private void Update()
        {
            if (IsGrounded() && jumpPressed)
            {
                isJumping = true;
                jumpTimeCount = jumpTime;
                rb.velocity = Vector2.up * jumpHeight;
            }

            if (jumpPressed && isJumping)
            {
                if (jumpTimeCount > 0)
                {
                    rb.velocity = Vector2.up * jumpHeight;
                    jumpTimeCount -= Time.deltaTime;
                }
                else
                {
                    isJumping = false;
                }
            }
        }

        private void FixedUpdate()
        {
            if (shouldMove)
                rb.velocity = new Vector2(inputActions.Platformer.Move.ReadValue<float>() * moveSpd * Time.deltaTime, rb.velocity.y);
        }
        
        
        private bool IsGrounded()
        {
            if (Physics2D.OverlapCircle(feet.position, rad, mask))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}