using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ProBuilder.Shapes;

public class BumpCollider : MonoBehaviour
{
    public Vector3 data;
    public Vector3 push;
    Rigidbody rb;
    public float force;
    ContactPoint[] contactPoints;
    public AnimationCurve bumpCurve;
    float bumpTimer;
    public float bumpDuration;
    public Vector3 question;
    public bool bam;
    bool zero;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        bam = false;
        zero = false;
    }
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.collider.CompareTag("Level"))
        {
            contactPoints = collision.contacts;
            Vector3 impact = contactPoints[0].point;
            data = transform.position - impact;
            push = new Vector3(data.x, 0, data.z).normalized;
            bam = true;
            zero = true;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.collider.CompareTag("Level"))
        {
            zero = false;
        }
    }
    private void FixedUpdate()
    {
        if (bam)
        {
            BumpScript(push);
            rb.AddForce(question * force);
        }
    }
    void BumpScript(Vector3 push)
    {
        if (bumpTimer < bumpDuration)
        {
            bumpTimer += Time.deltaTime;
            if (zero) bumpTimer = 0;
            float z = bumpCurve.Evaluate(bumpTimer / bumpDuration);
            question = push * z;
        }
        else
        {
            bumpTimer = 0;
            bam = false;
        }
    }
}
