using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    // Animator anim -- eventually once models are made;
    Rigidbody rb;
    Vector3 movement;
    

    public float speed = 1.0f;

    void Awake()
    {
        // anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }
    
    void Start()
    {

    }

 
    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        float r = Input.GetAxis("Mouse X");

        if (v != 0)
        {
            Vector3 velocityV = transform.forward * speed * Time.deltaTime * v;
            rb.MovePosition(rb.position + velocityV * 0.5f);
        }

        if (h != 0)
        {
            Vector3 velocityH = transform.right * speed * Time.deltaTime * h;
            rb.MovePosition(rb.position + velocityH * 0.5f);
        }

        if (r != 0)
        {
            transform.Rotate(Vector3.up * r * Time.deltaTime);
        }
    }
}
