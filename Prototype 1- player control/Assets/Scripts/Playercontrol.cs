using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontrol : MonoBehaviour
{
    public float speed = 10f;
    public float Rotationspeed = 45f;

    private float _horizontalInput;
    private float _verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _verticalInput = Input.GetAxis("Vertical");
        _horizontalInput = Input.GetAxis("Horizontal");

        // Move the vehicle foward 
        transform.Translate(Vector3.forward * speed * _verticalInput * Time.deltaTime);

        // Turn the vehicle
        transform.Rotate(Vector3.up, Rotationspeed *_horizontalInput * Time.deltaTime);

            
    }
}
