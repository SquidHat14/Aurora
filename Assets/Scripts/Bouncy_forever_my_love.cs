using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncy_forever_my_love : Platform
{

    void OnCollisionEnter2D(Collision2D collision)
    {
        //if (collision.gameObject.tag == "Ball")
        //{
            anim.SetTrigger("Made Contact");
        //}
    }

}
