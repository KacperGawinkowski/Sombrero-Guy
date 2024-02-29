using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    bool sigmus;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            sigmus = !sigmus;
            if(sigmus)
            {
                this.gameObject.transform.GetChild(2).gameObject.SetActive(sigmus);
                Time.timeScale = 0;
            }
            else
            {
                this.gameObject.transform.GetChild(2).gameObject.SetActive(sigmus);
                Time.timeScale = 1;
            }
        }
    }
}
