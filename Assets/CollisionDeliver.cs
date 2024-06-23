using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDeliver : MonoBehaviour
{
    [SerializeField] Color32 hasPackageColor = new Color32(1 ,1, 1, 255);
    [SerializeField] Color32 noPackageColor = new Color32(255 ,255, 255, 255);
    [SerializeField] float destroyDelay = 0.5f;
    bool hasPackage;
    SpriteRenderer spriteRenderer;

    private void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("collision detected");
    }

    private void OnTriggerEnter2D(Collider2D other) {
        // 
        // usa a tag previously added to an object to use it as a reference to identify the collision
        // on an specific object
        if (!hasPackage && other.tag == "Package")
        {   hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject, destroyDelay);
            Debug.Log("trigger package detected");
        }
        if (hasPackage && other.tag == "CustomerGoal1")
        {
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
            Debug.Log("trigger goal deliver package detected");
        }
    }

}
