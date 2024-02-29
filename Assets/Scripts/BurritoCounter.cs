using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class BurritoCounter : MonoBehaviour
{
    public GameObject[] burritoUI;
    public GameObject[] burritoObject;
    public int gatheredBurrito;

    public GameObject blueScreenPrefab;
    private GameObject blueScreen;

    public GameObject errorObject;

    public GameObject camera;
    public GameObject player;

    public void AddBurrito()
    {
        if (gatheredBurrito < 4)
        {
            gatheredBurrito += 1;
            burritoUI[gatheredBurrito - 1].GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            if( gatheredBurrito != 4)
            {
                burritoUI[gatheredBurrito].SetActive(true);
                burritoObject[gatheredBurrito].SetActive(true);
                burritoUI[gatheredBurrito].GetComponent<Image>().color = new Color32(90, 90, 90, 110);
            }
            SetBurritoEffect();
        }
    }

    private void SetBurritoEffect()
    {
        switch (gatheredBurrito)
        {
            case 1:
                blueScreen = Instantiate(blueScreenPrefab, GameObject.Find("Canvas").transform);
                Time.timeScale = 0;
                Destroy(blueScreen, 0.5f);
                FindObjectOfType<PlayerController>().changeMovementBingings();

                foreach (var item in GameObject.FindGameObjectsWithTag("Enemy"))
                {
                    Destroy(item);
                }
                break;
            case 2:
                blueScreen = Instantiate(blueScreenPrefab, GameObject.Find("Canvas").transform);
                Time.timeScale = 0;
                Destroy(blueScreen, 0.5f);
                errorObject.SetActive(true);

                foreach (var item in GameObject.FindGameObjectsWithTag("Enemy"))
                {
                    Destroy(item);
                }
                break;
            case 3:
                blueScreen = Instantiate(blueScreenPrefab, GameObject.Find("Canvas").transform);
                Time.timeScale = 0;
                Destroy(blueScreen, 0.5f);
                camera.GetComponent<CameraRenderTexture>().enabled = true;

                foreach (var item in GameObject.FindGameObjectsWithTag("Enemy"))
                {
                    Destroy(item);
                }
                break;
            case 4:
                blueScreen = Instantiate(blueScreenPrefab, GameObject.Find("Canvas").transform);
                blueScreen.gameObject.transform.GetChild(0).GetComponent<Text>().text = "Its finally time to go home";
                Time.timeScale = 0;
                Destroy(blueScreen, 0.5f);
                player.GetComponent<EnemySpawn>().enabled = false;
                foreach (var item in GameObject.FindGameObjectsWithTag("Enemy"))
                {
                    Destroy(item);
                }

                foreach (GameObject item in GameObject.FindGameObjectsWithTag("smietnik"))
                {
                    item.GetComponent<EnemyAI>().enabled = true;
                    item.GetComponent<NavMeshAgent>().enabled = true;
                    item.GetComponent<CapsuleCollider>().isTrigger = true;
                }

                break;
            default:
                break;
        }
    }
}
