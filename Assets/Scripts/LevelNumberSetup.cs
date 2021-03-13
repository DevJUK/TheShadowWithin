using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CarterGames.TheShadowWithin
{
    public class LevelNumberSetup : MonoBehaviour
    {
        [SerializeField] private GameObject[] levels;
        
        
        void Awake()
        {
            for (int i = 0; i < levels.Length; i++)
            {
                levels[i].GetComponent<LevelButton>().id = i + 1;
            }
        }
    }
}