using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{   
    //Private Variables
    private float speed = 5.0f;
    private float turnSpeed = 25.0f;
    private float horizontalInput;
    private float verticalInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Move the vehicle forward
        //transform.Translate(0, 0, 1);
        //Better way of writing is to use Vector3


        //transform.Translate(Vector3.forward);//This moves the vechile according to device capacity of rendering
        //So to solve this we use delta.Time so that we have control over when this is called

        //this is where we get the Player Input
        //this is where we get the Player Input
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed *horizontalInput);
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }
}
