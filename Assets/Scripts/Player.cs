using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CarterGames.TheShadowWithin
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private float moveSpd;

        private Rigidbody2D rb;
        
        
        // Start is called before the first frame update
        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
        }
    }
}