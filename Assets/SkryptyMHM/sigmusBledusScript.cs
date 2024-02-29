using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sigmusBledusScript : MonoBehaviour
{

    public GameObject[] sigmusBledus;

    void Start()
    {
        InvokeRepeating("epilepsja", 0.8f, 0.05f);
    }

    void epilepsja()
    {
        for (int i = 0; i < sigmusBledus.Length; i++)
        {
            sigmusBledus[i].GetComponent<Image>().color = new Color32(0, 74, 255, 255);
        }

        sigmusBledus[Random.Range(0,5)].GetComponent<Image>().color = new Color32(0, 74, 255, 0);
    }
}
