// using System.Collections;
// using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    public GameObject player;
    // public float smoothSpeed = 0.125f;
    // public Vector3 offset;

    // void FixedUpdate() 
    // {
    //     Vector3 desiredPosition = target.position + offset;
    //     Vector3 smoothPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
    //     transform.position = smoothPosition;

    //     transform.LookAt(target);
    // }
    // public GameObject player;

    void FixedUpdate()
    {
        if(player != null)
        {
            transform.position = new Vector3(target.transform.position.x, target.transform.position.y, transform.position.z);
        }
    }

}
