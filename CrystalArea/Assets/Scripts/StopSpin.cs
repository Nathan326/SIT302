using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StopSpin : MonoBehaviour
{
    public void SpinStop()
    {
        CrystalSpin deactive;
        deactive = gameObject.GetComponent<CrystalSpin>();
        deactive.enabled = false;
    }
    public void StartSpin()
    {
        CrystalSpin deactive;
        deactive = gameObject.GetComponent<CrystalSpin>();
        deactive.enabled = true;
    }
    CrystalSpin deactive;
    // Start is called before the first frame update
    void Start()
    {
        deactive = gameObject.GetComponent<CrystalSpin>();
    }

    // Update is called once per frame
    void Update()
    {
    }
}