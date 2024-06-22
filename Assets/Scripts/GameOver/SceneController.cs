using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace GameOver
{
    public class SceneController : MonoBehaviour
    {
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
