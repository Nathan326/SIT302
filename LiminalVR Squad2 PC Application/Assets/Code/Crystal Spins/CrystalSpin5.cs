using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalSpin5 : MonoBehaviour
{
    public bool rotateObject = false;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Behaviour>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.gameObject.name == "Crystal5")
            {
                if (Input.GetMouseButtonDown(0))
                {
                    if (rotateObject == true)
                    {
                        rotateObject = false;
                    }
                    else
                    {
                        rotateObject = true;
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
    }

}




