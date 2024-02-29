using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    public float timeMin = 0.1f;
    public float timeMax = 2f;
    public GameObject[] cars;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CarSpawn());
    }

    private IEnumerator CarSpawn()
    {
        float timeToSpawn = Random.Range(timeMin, timeMax);

        yield return new WaitForSeconds(timeToSpawn);
        Instantiate(cars[Random.Range(0,cars.Length)], transform.position, transform.rotation);

        StartCoroutine(CarSpawn());
    }
}
