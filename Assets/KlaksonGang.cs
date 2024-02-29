using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KlaksonGang : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            GetComponent<AudioSource>().Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "Player")
        {
            GetComponent<AudioSource>().Stop();
        }
    }
}
