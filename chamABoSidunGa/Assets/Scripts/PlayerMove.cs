using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    float moveSpeed, h, v;
    Vector3 dir;

    void Start()
    {
        dir = Vector3.zero;
        moveSpeed = 10f;
    }

    
    void Update()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

        dir.x = h;
        dir.z = v;
        dir = dir.normalized;
        transform.localPosition += dir * moveSpeed * Time.deltaTime;
    }
}
