using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Block : MonoBehaviour
{

    public void poka()
    {
        foreach (Transform item in transform)
        {
            if (item.gameObject.name != "Ground")
            {
                item.gameObject.SetActive(true);
            }
        }
    }

    public void ukryj()
    {
        foreach (Transform item in transform)
        {
            if (item.gameObject.name != "Ground")
            {
                item.gameObject.SetActive(false);
            }
        }
    }
}
