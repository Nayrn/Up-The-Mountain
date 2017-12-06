using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private float speed;

    private Rigidbody rb;

	// Use this for initialization
	void Start ()
    {
        speed = 5.0f;
        rb = this.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
    {

		//check for input and movement here


	}

    void FixedUpdate()
    {
       float moveX = Input.GetAxis("Horizontal");
       float moveZ = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(moveX, 0.0f, moveZ);

        rb.velocity = move * speed;
    }
}
