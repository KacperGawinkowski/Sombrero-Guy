using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurritoGatherer : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.name == "Player")
        {
            FindObjectOfType<BurritoCounter>().AddBurrito();
            gameObject.SetActive(false);
        }
    }
}
