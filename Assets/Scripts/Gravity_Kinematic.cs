using UnityEngine;
using System.Collections;
using System;

[System.Serializable]
[RequireComponent(typeof(Controller2D))]
public class Gravity_Kinematic : MonoBehaviour
{

    public float jumpHeight = 4;
    public float accelerationTimeAirborne = .2f;
    public float accelerationTimeGrounded = .18f;
    public float moveSpeed = 4;

    public float gravity;

    [HideInInspector]
    public Vector3 velocity;
    public float velocityXSmoothing;

    [HideInInspector]
    public Controller2D controller;
    float Xscale;

    void Awake()
    {

    }


    void Start()
    {
        controller = GetComponent<Controller2D>();
    }

    void FixedUpdate()
    {
            if (controller.collisions.above)
            {
                velocity.y = 0;
            }

            if (controller.collisions.below)
            {
                velocity.y = 0;
            }

            velocity.x = 0;
        

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);


    }
    private void Update()
    {

    }
}