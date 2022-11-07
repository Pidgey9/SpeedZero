using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamPosition : MonoBehaviour
{
    public Vector3 pos;
    public Vector3 angle;
    private void Update()
    {
        transform.position = GameObject.Find("Player").transform.position + pos;
        transform.rotation = GameObject.Find("Player").transform.rotation;
    }
}
