using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderMove : MonoBehaviour
{
    // Start is called before the first frame update
    public float min = -10f;
    public float max = 10f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        transform.position = new Vector3(Mathf.PingPong(Time.time * 4, max - min) + min, transform.position.y, transform.position.z);
        if (transform.position.x < -9.8f)
        {
            transform.eulerAngles = new Vector3(0, 0, 90);
        }
        if (transform.position.x > 9.8f)
        {
            transform.eulerAngles = new Vector3(90, 0, 90);
        }
    }
}
