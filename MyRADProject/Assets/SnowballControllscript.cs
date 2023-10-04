using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowballControllscript : MonoBehaviour
{
    Rigidbody rb;
    internal int check = 5;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    internal void ImThrowingYou(HumanControl humanControl)
    {
        transform.position = humanControl.transform.position + 2* Vector3.up + 3 * humanControl.transform.forward;
        rb = GetComponent<Rigidbody>();
        rb.velocity = 10 * (2 * Vector3.up + 3 * humanControl.transform.forward);
    }
}
