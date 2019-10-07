using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CamMove : MonoBehaviour
{
    // Start is called before the first frame update
    public void ResetCamera()
    {
        transform.eulerAngles = new Vector3(0, 0, 0);
    }
    float speed;

    void Start()
    {
        speed = 5f;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.eulerAngles = new Vector3(transform.eulerAngles.x - 1, transform.eulerAngles.y, transform.eulerAngles.z);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.eulerAngles = new Vector3(transform.eulerAngles.x + 1, transform.eulerAngles.y, transform.eulerAngles.z);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y - 1, transform.eulerAngles.z);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y + 1, transform.eulerAngles.z);
        }
    }
}