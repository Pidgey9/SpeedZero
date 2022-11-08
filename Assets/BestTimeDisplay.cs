using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BestTimeDisplay : MonoBehaviour
{
    TextMeshProUGUI text;
    public VarFloat best;
    private void Awake()
    {
        text = GetComponent<TextMeshProUGUI>();
    }
    private void Update()
    {
        text.text = best.value.ToString();
    }
}
