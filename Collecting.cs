using UnityEngine;
using StarterAssets;
using UnityEngine.InputSystem;

public class Collecting : MonoBehaviour
{
    
    public ItemScriptableObject item;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    Debug.Log("Item Collided with " + collision.gameObject.tag);
    //    if (collision.gameObject.tag == "Player")
    //    {
    //        Collect(this.tag);
    //    }
    //}

    private void Collect(ControllerColliderHit hit)
    {

        Debug.Log("Collected " + name + " " + item.ItemName);
    }


}
