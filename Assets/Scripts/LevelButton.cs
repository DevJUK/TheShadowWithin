using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

namespace CarterGames.TheShadowWithin
{
    public class LevelButton : MonoBehaviour
    {
        private TMP_Text levelNumber;
        
        public int id;
        

        private void Start()
        {
            levelNumber = GetComponentInChildren<TMP_Text>();
            levelNumber.text = id.ToString();
        }
        
        
        public void OpenLevel()
        {
            SceneManager.LoadSceneAsync("Level " + id);
        }
    }
}