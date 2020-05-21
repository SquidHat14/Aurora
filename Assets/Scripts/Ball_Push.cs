using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Push : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D c)
    {
        float force = 3;

        // If the object we hit is the enemy
        if (c.gameObject.tag == "Player")
        {
            Vector3 contactPoint = new Vector3(c.contacts[0].point.x, c.contacts[0].point.x, 0);
            Debug.Log(c.contacts[0].point);
            // Calculate Angle Between the collision point and the player
            Vector3 dir = contactPoint - transform.position;
            // We then get the opposite (-Vector3) and normalize it
            dir = -dir.normalized;
            // And finally we add force in the direction of dir and multiply it by force. 
            // This will push back the player

            GetComponent<Rigidbody2D>().AddForce(dir * force);
        }
    }
}
