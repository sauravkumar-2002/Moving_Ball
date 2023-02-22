using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float keyinput;
    void Start()
    {
        Debug.Log("Hello");  
    }

    // Update is called once per frame
    void Update()
    {
        //move the ball horizontally
        keyinput=Input.GetAxis("Horizontal");
        GetComponent<Rigidbody>().velocity=new Vector3(keyinput,GetComponent<Rigidbody>().velocity.y,0);
        
        //jump the ball
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up*10,ForceMode.VelocityChange);
        }
        
    }
}
