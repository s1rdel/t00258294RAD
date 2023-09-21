using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VladyslavFirstProject : MonoBehaviour
{
    private float angle;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 7, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) { 
            transform.position += Vector3.forward * Time.deltaTime; 
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up,90 * Time.deltaTime);
        }

    }
}
