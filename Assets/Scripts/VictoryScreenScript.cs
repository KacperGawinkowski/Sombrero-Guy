using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VictoryScreenScript : MonoBehaviour
{
    private float time = 8f;
    public Sprite thirdScreen;
    int state = 0;

    private void Start()
    {
        InvokeRepeating("zmianaTla", 5f, 5f);
    }

    void zmianaTla()
    {
        if(state == 0)
        {
            this.gameObject.transform.GetChild(0).gameObject.transform.GetComponent<Image>().sprite = thirdScreen;
            state += 1;
        }
        else if(state == 1)
        {
            SceneManager.LoadScene("MainMenuScene", LoadSceneMode.Single);
        }
    }
}
