using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    public float numberSpeed = 100;
    float currentSpeed;
    public Rigidbody Rb;
    void Start()
    {
       Rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame

     void FixedUpdate()
    {
        if (Keyboard.current.aKey.isPressed)
        {
            Rb.freezeRotation = false;
            currentSpeed = numberSpeed;
            Debug.Log("<color=green>Jump</color>");
            Rb.AddTorque(Vector3.up * currentSpeed);

        }
        else if (Keyboard.current.dKey.isPressed)
        {
            Rb.freezeRotation = false;
            currentSpeed = numberSpeed;
            Debug.Log("<color=green>Jump</color>");
            Rb.AddTorque(Vector3.down * currentSpeed);
        }
        else
        {
            currentSpeed = 0;
            Rb.freezeRotation = true;
        }


    }

    void Update()
    {
       
    }
}
