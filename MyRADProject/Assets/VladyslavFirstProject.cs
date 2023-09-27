using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VladyslavFirstProject : MonoBehaviour
{
    Rigidbody myRb;

    // Start is called before the first frame update
    void Start()
    {
       myRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) {

            myRb.AddForce(transform.forward);
            
            //transform.position += transform.forward * Time.deltaTime; 
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {

            myRb.AddExplosionForce(10,transform.position + Vector3.down,5);

            //transform.position += transform.forward * Time.deltaTime; 
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up,90 * Time.deltaTime);
        }

    }
}
