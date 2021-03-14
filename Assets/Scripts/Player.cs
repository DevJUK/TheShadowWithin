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
        private Actions inputActions;
        [SerializeField] private bool shouldMove;
        [SerializeField] private bool canJump;


        private void OnEnable()
        {
            inputActions = new Actions();
            inputActions.Platformer.Move.started += CanMovement;
            inputActions.Platformer.Move.canceled += StopMovement;
            inputActions.Platformer.Jump.performed += Jump;
            inputActions.Enable();
        }


        private void OnDisable()
        {
            inputActions.Disable();
        }

        // Start is called before the first frame update
        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
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


        private void Jump(InputAction.CallbackContext ctx)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpHeight);
        }


        private void FixedUpdate()
        {
            if (shouldMove)
                rb.velocity = new Vector2(inputActions.Platformer.Move.ReadValue<float>() * moveSpd * Time.smoothDeltaTime, rb.velocity.y);
        }
    }
}