using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetTimer : MonoBehaviour
{
    public Var rTime;
    public VarFloat time;
    public VarFloat bestTime;
    private void Awake()
    {
        rTime.value = true;
        time.value = 0;
        bestTime.value = 100;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Finish"))
        {
            rTime.value = true;
            if (bestTime.value > time.value && time.value != 0)
            {
                bestTime.value = time.value;
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Finish"))
        {
            rTime.value = false;
            time.value = 0;
        }
    }
}
