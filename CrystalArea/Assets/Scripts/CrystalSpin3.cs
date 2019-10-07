﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalSpin3 : MonoBehaviour
{
    public bool rotateObject = false;
    public bool playMusic = false;

    public AudioClip Crystal3Clip;

    public AudioSource Crystal3Source;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Behaviour>().enabled = false;
        Crystal3Source.clip = Crystal3Clip;
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.gameObject.name == "Crystal3")
            {
                if (Input.GetMouseButtonDown(0))
                {
                    if (rotateObject == true)
                    {
                        rotateObject = false;
                        playMusic = false;
                        Crystal3Source.Stop();
                    }
                    else
                    {
                        rotateObject = true;
                        playMusic = true;
                    }
                    if (GetComponent<Behaviour>().enabled == false)
                    {
                        GetComponent<Behaviour>().enabled = true;
                    }
                    else
                    {
                        GetComponent<Behaviour>().enabled = false;
                    }
                }

            }
        }
        else
        {
            Debug.Log("This isn't a Player");
        }
        if (rotateObject == true)
        {
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y + 0.5f, transform.eulerAngles.z);
        }
        if (playMusic == true)
        {
            Crystal3Source.Play();
            playMusic = false;
        }
    }

}



