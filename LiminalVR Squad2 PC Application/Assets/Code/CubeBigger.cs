﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#pragma strict

public class CubeBigger : MonoBehaviour
{
    // Start is called before the first frame update
    float ypa;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ypa = transform.localScale.y;

        transform.localScale += new Vector3(0, 0.1f, 0);

        if (ypa > 10)
        {
            this.enabled = false;
        }
    }
}