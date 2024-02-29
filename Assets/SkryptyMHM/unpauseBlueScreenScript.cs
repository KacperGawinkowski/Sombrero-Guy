using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unpauseBlueScreenScript : MonoBehaviour
{
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Time.timeScale = 1;
        }
        if (Input.GetMouseButtonDown(1))
        {
            Time.timeScale = 1;
        }
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            Time.timeScale = 1;
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 1;
        }
    }
}
