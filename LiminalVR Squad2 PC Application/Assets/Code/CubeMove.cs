﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{
    float x;
    float y;
    float z;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        x = transform.position.x;
        y = transform.position.y;
        z = transform.position.z;

        if (Input.GetKey(KeyCode.A))
        {
            transform.position = new Vector3(x - 0.1f, y, z);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position = new Vector3(x + 0.1f, y, z);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position = new Vector3(x, y + 0.1f, z);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position = new Vector3(x, y - 0.1f, z);
        }
        if (y < 0)
        {
            transform.position = new Vector3(x, 0, z);
        }
    }

}