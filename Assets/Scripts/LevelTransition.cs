using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CarterGames.Assets.SaveManager;

namespace CarterGames.TheShadowWithin
{
    public class LevelTransition : MonoBehaviour
    {
        [SerializeField] private Animator anim; 
        private bool isTriggered;

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (!other.CompareTag("Player")) return;

            Debug.Log("hit");
            
            if (!isTriggered)
                anim.SetBool("Transition", true); 
        }
    }
}