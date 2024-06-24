using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace GameOver
{
    
    public class SceneController : MonoBehaviour
    {
        public Button button;

        private void Start()
        {
            button.Select();
        }

        public void OnClickRetry()
        {
            SceneManager.LoadScene("masterscene");
        }

        public void OnClickTitle()
        {
            SceneManager.LoadScene("Title");
        }
    }
}
