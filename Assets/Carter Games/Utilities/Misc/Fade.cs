using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace CarterGames.Utilities
{
    public class Fade : MonoBehaviour
    {
        private bool shouldFade;
        private bool shouldIn;
        private Image toEdit;
        
        
        private void Update()
        {
            if (shouldFade)
            {
                if (shouldIn && !toEdit.color.a.Equals(1))
                {
                    toEdit.CrossFadeAlpha(1, 1f, false);
                }
                else
                {
                    shouldFade = false;
                }
            }
        }


        public void FadeIn(Image value)
        {
            shouldIn = true;
            shouldFade = true;
            toEdit = value;
        }
    }
}