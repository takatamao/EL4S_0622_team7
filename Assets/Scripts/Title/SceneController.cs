using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Title
{
    public class SceneController : MonoBehaviour
    {
        
        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetButtonDown("Button_A")) OnClickStart();
        }

        public void OnClickStart()
        {
            SceneManager.LoadScene("masterscene");
        }
    }
}
