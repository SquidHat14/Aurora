using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightable_Platform : MonoBehaviour
{
    void Start()
    {

    }


    void OnTriggerEnter2D(Collider2D c)
    {
        if (c.tag == "Light-Mesh-Ball")
        {
            Debug.Log("here1");
            gameObject.transform.parent.GetComponent<BoxCollider2D>().enabled = true;
        }
    }

    void OnTriggerExit2D(Collider2D c)
    {
        if (c.tag == "Light-Mesh-Ball")
        {
            Debug.Log("here2");
            gameObject.transform.parent.GetComponent<BoxCollider2D>().enabled = false;
        }
    }


    void OnTriggerStay2D(Collider2D c)
    {
        if (c.tag == "Light-Mesh-Ball")
        {
            Debug.Log("here3");
            gameObject.transform.parent.GetComponent<BoxCollider2D>().enabled = true;
        }
    }
}
