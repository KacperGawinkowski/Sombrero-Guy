using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sigmaScript : MonoBehaviour
{
    public int sigma;
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if(sigma == 1)
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
