using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] private float forceValue;
    [SerializeField] private float rotationValue;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        ProcessForce(forceValue);
        ProcessRotation();
    }
    void ProcessForce(float force)
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddRelativeForce(Vector3.up * force * Time.deltaTime, ForceMode.Force);
        }
    }
    void ProcessRotation()
    {
        if (Input.GetKey(KeyCode.A))
        {
            ApplyRotate(-rotationValue);

        }
        else if (Input.GetKey(KeyCode.D))
        {
            ApplyRotate(rotationValue);
        }

    }
    void ApplyRotate(float rotateThisFramValue)
    {
        rb.freezeRotation = true;
        transform.Rotate(new Vector3(1, 0, 0) * rotateThisFramValue * Time.deltaTime);
        rb.freezeRotation = false;
    }
}
