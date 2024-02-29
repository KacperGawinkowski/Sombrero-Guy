using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ErrorEffect : MonoBehaviour
{

    public GameObject[] errorEffects;

    void Start()
    {
        InvokeRepeating("epilepsja", 0.8f, 0.05f);
    }

    void epilepsja()
    {
        for (int i = 0; i < errorEffects.Length; i++)
        {
            errorEffects[i].GetComponent<Image>().color = new Color32(0, 74, 255, 255);
        }

        errorEffects[Random.Range(0,5)].GetComponent<Image>().color = new Color32(0, 74, 255, 0);
    }
}
