using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemySpawn : MonoBehaviour
{
    
    public GameObject enemy;
    private int spawnRange = 22;
    public int enemyCount = 3;

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

        GameObject go = Instantiate(enemy, new Vector3(transform.position.x + x * spawnRange, 0, transform.position.z + z * spawnRange), Quaternion.identity);

        if (go.GetComponent<NavMeshAgent>().isOnNavMesh == false)
        {
            Destroy(go);
        }
    }
}
