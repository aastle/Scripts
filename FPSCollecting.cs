using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using StarterAssets;

public class FPSCollecting : MonoBehaviour
{
    public ItemScriptableObject item;
    public LayerMask pushLayers;
    private StarterAssetsInputs starterAssetsInputs;
    private bool collided;


    // Start is called before the first frame update
    void Start()
    {
        starterAssetsInputs = this.GetComponent<StarterAssetsInputs>();
        collided = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (starterAssetsInputs.collect && collided)
        {
            Debug.Log("Collected " + name + " " + item.ItemName + " " + gameObject.tag);

            starterAssetsInputs.collect = false;

        }

    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        
        CollectTheItem(hit);
    }
    private void CollectTheItem(ControllerColliderHit hit)
    {
        // make sure we hit a non kinematic rigidbody
        Rigidbody body = hit.collider.attachedRigidbody;
        if (body == null || body.isKinematic) return;

        // make sure we only push desired layer(s)
        var bodyLayerMask = 1 << body.gameObject.layer;
        if ((bodyLayerMask & pushLayers.value) == 0) return;

        // We don't want to push objects below us
        if (hit.moveDirection.y < -0.3f) return;

        if (hit.gameObject.tag == "collectable")
        { collided = true; }

    }

    protected void OnCollisionStay(Collision collision)
    {
         if (starterAssetsInputs.collect && collision.gameObject.tag == "collectable")
        {
            //Debug.Log("Collected " + name + " " + item.ItemName + " " + collision.gameObject.tag);

            starterAssetsInputs.collect = false;
            
        }
       
    }
}
