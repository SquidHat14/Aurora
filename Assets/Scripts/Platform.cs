using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public GameObject Ball;
    public Animator anim;
    public GameObject particle;

    public bool draggable = false;
    public bool dragging = false;
    private float distance;

    // Start is called before the first frame update
    protected void Start()
    {
        Ball = GameObject.FindGameObjectsWithTag("Ball")[0];
        anim = GetComponent<Animator>();
    }

    void OnMouseEnter()
    {

    }

    void OnMouseExit()
    {

    }

    void OnMouseDown()
    {
        distance = Vector3.Distance(transform.position, Camera.main.transform.position);
        if (draggable)
        {
            dragging = true;
        }
    }

    void OnMouseUp()
    {
        dragging = false;
    }

    void Update()
    {
        if (dragging)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 rayPoint = ray.GetPoint(distance);
            transform.position = rayPoint;
        }
    }
}
