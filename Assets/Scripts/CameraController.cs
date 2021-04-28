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

    void LateUpdate()
    {
        transform.position = target.transform.position + offset;

    }
}
