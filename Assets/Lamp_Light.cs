using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.LWRP;

public class Lamp_Light : MonoBehaviour
{

    CircleCollider2D cc;
    float LightRadius;
    Light2D The2DLights;

    int fadeDirection;

    void Start()
    {
        GameObject Light = gameObject.transform.parent.gameObject;
        The2DLights = Light.GetComponent<Light2D>();

        LightRadius = (float)(The2DLights.shapeLightParametricRadius + The2DLights.shapeLightFalloffSize);

        cc = gameObject.AddComponent(typeof(CircleCollider2D)) as CircleCollider2D;
        cc.radius = LightRadius;

        fadeDirection = 1;
        StartCoroutine(LightBreathe());
    }

    void FixedUpdate()
    {
        gameObject.transform.position += new Vector3(0f,0f,.0000001f);

        LightRadius = (float)(The2DLights.shapeLightParametricRadius + The2DLights.shapeLightFalloffSize) - (1 - The2DLights.intensity);
        cc.radius = LightRadius;

        if ((The2DLights.intensity >= 1f && fadeDirection == 1) || (The2DLights.intensity <= .2f && fadeDirection == -1))
        {
            fadeDirection *= -1;
        }
    }

    IEnumerator LightBreathe()
    {
        
        while(true)
        {
            yield return new WaitForSeconds(.01f);
            The2DLights.intensity += .004f * fadeDirection;
        }
    }
}
