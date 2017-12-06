using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pMovement : MonoBehaviour
{
    private float speed;
    private bool falling;
    private Rigidbody rb;

    // Use this for initialization
    void Start()
    {
        speed = 5.0f;
        rb = this.GetComponent<Rigidbody>();
        falling = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (falling == true)
            FallProperly();
    }

    void FixedUpdate()
    {
        float moveZ = Input.GetAxis("Horizontal");
        float moveX = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(moveX, 0.0f, -moveZ);

        rb.velocity = move * speed;

        if(Input.GetKey(KeyCode.Space))
        {
            float moveY = 1.0f;

            Vector3 jump = new Vector3(moveX, moveY, 0.0f);
            
            rb.velocity = jump * speed;
            falling = true;
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "floor" || col.gameObject.tag == "platform")
            falling = false;
    }

    void OnCollisionExit(Collision col)
    {
        if (col.gameObject.tag == "floor" || col.gameObject.tag == "platform")
            falling = true;
        
    }

    void FallProperly()
    {
        rb.AddForce(0.0f, -800.0f, 0.0f);
    }
}
