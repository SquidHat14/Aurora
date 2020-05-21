using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.LWRP;


public class Create_Mesh_Collider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject Light = gameObject.transform.parent.gameObject;
        Light2D The2DLights = Light.GetComponent<Light2D>();

        float radius = (float)(The2DLights.shapeLightParametricRadius + The2DLights.shapeLightFalloffSize);

        CircleCollider2D cc = gameObject.AddComponent(typeof(CircleCollider2D)) as CircleCollider2D;

        cc.radius = radius;
    }
}
