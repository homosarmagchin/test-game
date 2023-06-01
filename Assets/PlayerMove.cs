using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 1000f;
    public float value;
    Vector3 back = Vector3.zero;
    public Rigidbody rb;

    void FixedUpdate()
    {
        // rb.AddForce(0, 0, speed * Time.deltaTime);
        rb.velocity = Vector3.forward * speed * Time.fixedDeltaTime;
        // rb.useGravity=false;
    }
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            float offsetX = Input.mousePosition.x - back.x;
            offsetX *= value;

            transform.position = new Vector3(Mathf.Clamp(transform.position.x + offsetX, -10, 10), transform.position.y, transform.position.z);

            back = Input.mousePosition;
        }
    }
}