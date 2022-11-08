using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerDisplay : MonoBehaviour
{
    TextMeshProUGUI text;
    public Var rTime;
    public VarFloat timer;
    private void Awake()
    {
        text = GetComponent<TextMeshProUGUI>();
        timer.value = 0;
    }
    private void Update()
    {
        text.text = timer.value.ToString();
        if (rTime.value)
        {
            timer.value = 0;
        }
        else timer.value += Time.deltaTime;
    }
}
