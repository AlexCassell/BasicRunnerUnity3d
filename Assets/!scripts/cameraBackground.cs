using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraBackground : MonoBehaviour {

    public Color color1 = Color.red;
    public Color color2 = Color.blue;
    public float duration = 3.0F;

    Camera cam;
    //borrowed from https://docs.unity3d.com/ScriptReference/Camera-backgroundColor.html
    void Start()
    {
        cam = GetComponent<Camera>();
        cam.clearFlags = CameraClearFlags.SolidColor;
    }

    void Update()
    {
        float t = Mathf.PingPong(Time.time, duration) / duration;
        cam.backgroundColor = Color.Lerp(color1, color2, t);
    }
}
