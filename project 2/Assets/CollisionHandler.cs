using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject objectToDestroy;
    
    void OnCollisionEnter(Collision C)
    {
        Debug.Log(C.collider.tag);
        if(C.collider.tag=="Player")
        {
            Debug.Log("we gained a coin");  
            // Increment the player's score
            GameManager.Instance.IncrementScore(); 
            Destroy(objectToDestroy);
            Debug.Log("Coin destroyed.");  



        }

    }
    
}
