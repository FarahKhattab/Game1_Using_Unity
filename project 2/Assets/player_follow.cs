using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_follow : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;
    public Vector3 offset;
    int view=0;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKeyDown(KeyCode.F))
         {
            view =1;  
         }
         if (Input.GetKeyDown(KeyCode.A))
         {
            view=0;  
         }
        if (view==1)
        {
            transform.position = player.position;
        }
        else
        {
            transform.position = player.position + offset;
        }
    }
}
