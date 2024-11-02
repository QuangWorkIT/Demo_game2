using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_behavior : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update

    public float forwardForce = 1000f;
    public float sideForce = 1000f;
    // Update is called once per frame
    void Update()
    {
        rb.AddForce(0,0,forwardForce* Time.deltaTime);
        if(Input.GetKey("a")){
            rb.AddForce(-sideForce*Time.deltaTime,0,0, ForceMode.VelocityChange);
        }else if(Input.GetKey("d")){
            rb.AddForce(sideForce*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
    } 

    public player_behavior behavior;

    void OnCollisionEnter(Collision objectCollision)
    {
        if (objectCollision.collider.tag == "Obstacles")
        {
            behavior.enabled = false;
        }
    }



}
