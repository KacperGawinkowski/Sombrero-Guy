using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class burritoCounterScript : MonoBehaviour
{
    public GameObject[] BURRITO;
    public GameObject[] BURRITOBURRITO;
    public int gatheredBurrito;

    public GameObject blueScreenPrefab;
    private GameObject blueScreen;

    public GameObject sigmusBledus;

    public GameObject camera;
    public GameObject player;

    public void addBurrito()
    {
        if (gatheredBurrito < 4)
        {
            gatheredBurrito += 1;
            BURRITO[gatheredBurrito - 1].GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            if( gatheredBurrito != 4)
            {
                BURRITO[gatheredBurrito].SetActive(true);
                BURRITOBURRITO[gatheredBurrito].SetActive(true);
                BURRITO[gatheredBurrito].GetComponent<Image>().color = new Color32(90, 90, 90, 110);
            }
            setBurritoEffect();
        }
    }

    private void setBurritoEffect()
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
                sigmusBledus.SetActive(true);

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

    //1 burrito zmienia sterowanie DONE
    //2 utrudnienie podglądu ekranu poprzez losowe niebieskie kwadraty na ekranie DONE
    //3 3d kloc mhm DONE
    //4 smietniki gonia gracza, a przeciwnicy maja stanac w miejscu
    //5 creditsy DONE
    //  Nagrac nagranie,pokazac cale menu 2 nieudane podejscia, udane podejscie,enjoy your meal, creditsy, chory siedzacy w lozku, 
    //  pokazac jak wyjsc z aplikacji



}
