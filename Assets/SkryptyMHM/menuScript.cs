using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuScript : MonoBehaviour
{
    int triggerLvl = 0;

    public GameObject quitTextPrefab;
    private GameObject quitText;

    public GameObject backTextPrefab;
    private GameObject backText;

    public void PlayGame()
    {
        if(triggerLvl < 5)
        {
            changePlayButtonPosition();
            triggerLvl++;
        }
        else
        {
            SceneManager.LoadScene("SigmaScene", LoadSceneMode.Single);
        }
    }

    public void QuitGame()
    {
        quitText = Instantiate(quitTextPrefab, GameObject.Find("Canvas").transform);
        Destroy(quitText, 2f);
    }

    public void HowToPlay()
    {
        this.gameObject.transform.GetChild(3).gameObject.SetActive(true);
        this.gameObject.transform.GetChild(0).gameObject.SetActive(false);
        this.gameObject.transform.GetChild(1).gameObject.SetActive(false);
        this.gameObject.transform.GetChild(2).gameObject.SetActive(false);
    }

    private void changePlayButtonPosition()
    {
        this.gameObject.transform.GetChild(2).gameObject.transform.position = new Vector3(Random.Range(0, 960), Random.Range(0, 540), Random.Range(0, 0));
    }

    public void onBack()
    {
        backText = Instantiate(backTextPrefab, GameObject.Find("Canvas").transform);
        Destroy(backText, 2f);
    }

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            this.gameObject.transform.GetChild(3).gameObject.SetActive(false);
            this.gameObject.transform.GetChild(0).gameObject.SetActive(true);
            this.gameObject.transform.GetChild(1).gameObject.SetActive(true);
            this.gameObject.transform.GetChild(2).gameObject.SetActive(true);
        }
    }
}

