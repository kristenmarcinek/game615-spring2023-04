using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneScript : MonoBehaviour
{
    public float forwardSpeed = 50;
    public float rotateSpeed = 80;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float hAxis = Input.GetAxis("Horizontal");
        //float vAxis = Input.GetAxis("Vertical");

        gameObject.transform.Rotate(0, rotateSpeed * Time.deltaTime * hAxis, 0, Space.Self);
        gameObject.transform.Translate(transform.forward * forwardSpeed * Time.deltaTime, Space.World);
    }
}