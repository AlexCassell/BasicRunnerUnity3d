using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColors : MonoBehaviour { 
private Color colorStart = Color.red;
private Color colorEnd = Color.blue;
private float duration = 1.0F;
private Renderer rend;
void Start()
{
        duration = Random.Range(0.5f, 3.0f);
    rend = GetComponent<Renderer>();
}
void Update()
{
    float lerp = Mathf.PingPong(Time.time, duration) / duration;
    rend.material.color = Color.Lerp(colorStart, colorEnd, lerp);
}
}

