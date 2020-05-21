using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightable_Collision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SpriteRenderer sprRend = gameObject.GetComponentInParent(typeof(SpriteRenderer)) as SpriteRenderer;

        float spriteLength = sprRend.size.x;
        float spriteHeight = sprRend.size.y;

        float spriteLeft = transform.position.x - (spriteLength / 2);
        float spriteRight = transform.position.x + (spriteLength / 2);

        float spriteTop = transform.position.y + (spriteHeight / 2);
        float spriteBottom = transform.position.y - (spriteHeight / 2);


        Debug.Log("Length: " + spriteLength);


        float boxSize = .1f / transform.localScale.x;

        //Create small box colliders starting on the left side of the platform
        for (float i = -spriteLength / 2; i < spriteLength/2 - boxSize; i += boxSize)
        {
            GameObject childObject = new GameObject();
            childObject.transform.parent = gameObject.transform;
            childObject.transform.position = gameObject.transform.position;
            childObject.transform.localScale = new Vector3(1, 1, 1);
            childObject.transform.rotation = gameObject.transform.rotation;
            childObject.layer = gameObject.layer;
            childObject.tag = "Light-Mesh-Platform";
            BoxCollider2D bc = childObject.AddComponent<BoxCollider2D>();
            bc.enabled = false;
            bc.size = new Vector2(boxSize, spriteHeight);
            bc.offset = new Vector2(i + boxSize/2, 0f);



            GameObject childObject2 = new GameObject();
            childObject2.transform.parent = childObject.transform;
            childObject2.transform.position = gameObject.transform.position;
            childObject2.transform.localScale = new Vector3(1, 1, 1);
            childObject2.transform.rotation = gameObject.transform.rotation;
            childObject2.layer = 13;
            childObject2.tag = "Light-Mesh-Platform";
            childObject2.AddComponent<Lightable_Platform>();
            BoxCollider2D bc2 = childObject2.AddComponent<BoxCollider2D>();
            bc2.size = new Vector2(boxSize, spriteHeight);
            bc2.offset = new Vector2(i + boxSize / 2, 0f);
            bc2.isTrigger = true;
        }
        //Add the final box, knowing that it isnt going to be the full boxSize


        GameObject _childObject = new GameObject();
        _childObject.transform.parent = gameObject.transform;
        _childObject.transform.position = gameObject.transform.position;
        _childObject.transform.localScale = new Vector3(1, 1, 1);
        _childObject.transform.rotation = gameObject.transform.rotation;
        _childObject.layer = gameObject.layer;
        _childObject.tag = "Light-Mesh-Platform";
        BoxCollider2D _bc = _childObject.AddComponent<BoxCollider2D>();
        _bc.enabled = false;
        _bc.size = new Vector2(spriteLength % boxSize, spriteHeight);
        _bc.offset = new Vector2((spriteLength - (spriteLength % boxSize)) / 2, 0f);



        GameObject _childObject2 = new GameObject();
        _childObject2.transform.parent = _childObject.transform;
        _childObject2.transform.position = gameObject.transform.position;
        _childObject2.transform.localScale = new Vector3(1, 1, 1);
        _childObject2.transform.rotation = gameObject.transform.rotation;
        _childObject2.layer = 13;
        _childObject2.tag = "Light-Mesh-Platform";
        _childObject2.AddComponent<Lightable_Platform>();
        BoxCollider2D _bc2 = _childObject2.AddComponent<BoxCollider2D>();
        _bc2.size = new Vector2(spriteLength % boxSize, spriteHeight);
        _bc2.offset = new Vector2((spriteLength - (spriteLength % boxSize)) / 2, 0f);
        _bc2.isTrigger = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
