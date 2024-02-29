using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public int sceneInex;
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if(sceneInex == 1)
            {
                SceneManager.LoadScene("MainMenuScene", LoadSceneMode.Single);
            }
            else 
            {
                SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
            }
        }
    }
}
