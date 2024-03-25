using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_script : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce =2000f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("HII");
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(0,0,forwardForce*Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
             rb.AddForce(0,0,-forwardForce*Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-forwardForce*Time.deltaTime,0,0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(forwardForce*Time.deltaTime,0,0);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(0,forwardForce*Time.deltaTime*5,0);
        }
        else
        {
             rb.AddForce(0,0,0);
        }
        
    }
}
