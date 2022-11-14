using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Rigidbody rb;
    Vector3 move;
    public float speed;
    float h;
    float v;
    public float angle;
    public VarFloat speedy;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");
        move = ( transform.forward * v) * speed * Time.fixedDeltaTime;
        speedy.value = rb.velocity.magnitude;
    }
    void FixedUpdate()
    {
        rb.velocity = move * speed * Time.fixedDeltaTime;
        rb.angularVelocity = Vector3.up * h * angle * Time.fixedDeltaTime;
    }
}
