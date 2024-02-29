using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemySpawn : MonoBehaviour
{

    //public GameObject[] enemies;
    public GameObject enemy;
    private int spawnRange = 22;
    public int enemyCount = 3;
    /*
    // Start is called before the first frame update
    void Start()
    {
        
    }
    */
    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectsWithTag("Enemy").Length < enemyCount)
        {
            SpawnEnemy();
        }

        foreach (GameObject item in GameObject.FindGameObjectsWithTag("Enemy"))
        {
            if (Vector3.Distance(transform.position, item.transform.position) > 32)
            {
                Destroy(item);
            }
        }
    }

    private void SpawnEnemy()
    {
        int x = 1;
        int z = 1;
        if (Random.Range(0, 2) == 0)
        {
            x = -1;
        }
        if (Random.Range(0, 2) == 0)
        {
            z = -1;
        }

        GameObject balls = Instantiate(enemy, new Vector3(transform.position.x + x * spawnRange, 0, transform.position.z + z * spawnRange), Quaternion.identity);

        if (balls.GetComponent<NavMeshAgent>().isOnNavMesh == false)
        {
            Destroy(balls);
        }
    }
}
