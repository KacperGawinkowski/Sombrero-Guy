using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zebranieBurrito : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.name == "Player")
        {
            FindObjectOfType<burritoCounterScript>().addBurrito();
            this.gameObject.SetActive(false);
        }
    }
}
