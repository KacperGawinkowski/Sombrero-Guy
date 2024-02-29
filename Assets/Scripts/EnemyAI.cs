using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class EnemyAI : MonoBehaviour
{
    private NavMeshAgent agent;
    private GameObject player;
    private Animator anim;
    public bool canMove;
    private AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        player = GameObject.Find("Player");
        anim = GetComponentInChildren<Animator>();
        audio = GetComponent<AudioSource>();
        if(this.gameObject.tag != "smietnik")
        {
            anim.SetBool("walk", true);
        }

        StartCoroutine(Gwizdek());
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(player.transform.position);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "Player" && GetComponent<EnemyAI>().isActiveAndEnabled)
        {
            SceneManager.LoadScene("GameOverScene", LoadSceneMode.Single);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player" && GetComponent<EnemyAI>().isActiveAndEnabled)
        {
            SceneManager.LoadScene("GameOverScene", LoadSceneMode.Single);
        }
        if (other.gameObject.tag == "Car" && GetComponent<EnemyAI>().isActiveAndEnabled && this.gameObject.tag == "Enemy")
        {
            Destroy(this.gameObject);
        }
        if (other.gameObject.tag == "Car" && GetComponent<EnemyAI>().isActiveAndEnabled && this.gameObject.tag == "smietnik")
        {
            Destroy(other.gameObject);
        }
    }

    private IEnumerator Gwizdek()
    {
        if (gameObject.tag == "Enemy")
        {

        }
        float balls = Random.Range(10f, 60f);
        yield return new WaitForSeconds(balls);
        audio.Play();
        StartCoroutine(Gwizdek());
    }
}
