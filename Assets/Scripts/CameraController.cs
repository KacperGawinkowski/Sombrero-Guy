using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public List<GameObject> hidden;
    
    void Update()
    {
        RaycastHit[] hits;
        hits = Physics.RaycastAll(transform.position, transform.TransformDirection(Vector3.forward), Vector3.Distance(transform.position, GameObject.Find("Player").transform.position));

        for (int i = 0; i < hits.Length; i++)
        {
            RaycastHit hit = hits[i];

            hidden.Add(hit.transform.gameObject);
        }

        foreach (GameObject item in GameObject.FindGameObjectsWithTag("building"))
        {
            if (hidden.Contains(item))
            {
                item.GetComponent<Building>().Hide();
            }
            else
            {
                item.GetComponent<Building>().Show();
            }
        }

        hidden.Clear();
    }
}
