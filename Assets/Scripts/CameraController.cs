using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public Vector3 offsetRotated;
    public float rotationSpeed = 5f;
  


    void Start()
    {

        offset = transform.position - target.position;

    }

  


    void Update()
    {
        float yAngle = target.eulerAngles.y;
        float xAngle = target.eulerAngles.x;
        Quaternion rotation = Quaternion.Euler(xAngle, yAngle, 0);
        transform.position = target.position + (rotation * offset);
       
        transform.LookAt(target);
    }
}
