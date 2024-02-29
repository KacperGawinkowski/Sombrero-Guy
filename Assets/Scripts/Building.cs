using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Building : MonoBehaviour
{
    public void Show()
    {
        foreach (Transform item in transform)
        {
            if (item.gameObject.name != "Ground")
            {
                item.gameObject.SetActive(true);
            }
        }
    }

    public void Hide()
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
