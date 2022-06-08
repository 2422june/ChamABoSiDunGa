using System;
using UnityEngine;
using UnityEngine.UI;

public class CursorController : MonoBehaviour
{
    Vector3 mousePos;
    float w, h;

    void Start()
    {
        Input.mousePosition.Set(0, 0, 0);
        w = 861f / 1920f;
        h = 420f / 1080f;

        Debug.Log($"w = {w}\n h = {h}");
    }

    void Update()
    {
        mousePos = Input.mousePosition;

        //1920 : 1080 = 861 : 420 
        //960 : 540

        /*if (mousePos.x > 451)
            mousePos.x = 451;

        if (mousePos.x < -410)
            mousePos.x = -410;

        if (mousePos.y < -120)
            mousePos.y = -120;

        if (mousePos.y > 300)
            mousePos.y = 300;*/

        mousePos.x = w * (Input.mousePosition.x - 960);
        mousePos.y = h * (Input.mousePosition.y - 540);
        

        //Input.mousePosition.Set(mousePos.x, mousePos.y, mousePos.z);
        Debug.Log(Input.mousePosition);
        transform.position = mousePos;
    }
}
