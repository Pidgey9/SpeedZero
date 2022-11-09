using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumpCollider : MonoBehaviour
{
    public Vector3 data;
    public Vector3 push;
    Rigidbody rb;
    public float force;
    public ContactPoint[] contactPoints;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        contactPoints = collision.contacts;
        if (collision.collider.CompareTag("Level"))
        {
            Debug.Log(contactPoints);
        }
    }



    /*private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Level"))
        {
            data = transform.position - other.transform.position;
            Vector3 pos = other.ClosestPointOnBounds(data);
            Vector3 data2 = transform.position - pos;
            push = new Vector3(data2.x, 0, data2.z).normalized;
            rb.AddForce(push * force * Time.fixedDeltaTime);

        }
    }*/
}
