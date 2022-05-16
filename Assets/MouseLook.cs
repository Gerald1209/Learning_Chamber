using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensiblilty = 80f;
    public Transform player;
    private float xRotation;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensiblilty * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensiblilty * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        
        transform.localRotation = Quaternion.Euler(xRotation,0f,0f);
        player.Rotate(Vector3.up * mouseX);
    }
}
