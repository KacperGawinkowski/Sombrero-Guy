using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameScript : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (FindObjectOfType<BurritoCounter>().gatheredBurrito == 4)
        {
            if (collision.collider.name == "Player")
            {
                SceneManager.LoadScene("ZWYCIESTWO", LoadSceneMode.Single);
            }

        }
    }
}
