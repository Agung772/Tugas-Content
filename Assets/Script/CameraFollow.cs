using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public float speedCam;
    public Transform playerTarger;
    public Vector3 offset;
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, playerTarger.position + offset, speedCam * Time.deltaTime);
    }
}
