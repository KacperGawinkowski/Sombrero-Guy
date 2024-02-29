using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public List<GameObject> ukryte;

    // Start is called before the first frame update
    void Start()
    {
        //ukryty = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit[] hits;
        hits = Physics.RaycastAll(transform.position, transform.TransformDirection(Vector3.forward), Vector3.Distance(transform.position, GameObject.Find("Player").transform.position));

        for (int i = 0; i < hits.Length; i++)
        {
            RaycastHit hit = hits[i];

            ukryte.Add(hit.transform.gameObject);
        }

        foreach (GameObject item in GameObject.FindGameObjectsWithTag("building"))
        {
            if (ukryte.Contains(item))
            {
                item.GetComponent<Block>().ukryj();
            }
            else
            {
                //Debug.Log(item);
                item.GetComponent<Block>().poka();
            }
        }

        ukryte.Clear();


        /*
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
        {
            ukryty = hit.transform.gameObject;
        }

        foreach (GameObject item in GameObject.FindGameObjectsWithTag("building"))
        {
            Debug.Log(item);
            if (ukryty == item)
            {
                item.GetComponent<Block>().ukryj();
            }
            else
            {
                item.GetComponent<Block>().poka();
            }
        }
        */
    }
}
