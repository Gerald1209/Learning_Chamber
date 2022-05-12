using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSCamera : MonoBehaviour
{
    public Vector2 sensibility;
    private new Transform camera;
    // Start is called before the first frame update
    void Start()
    {
        camera = transform.Find("Main Camera");

        //Permite que el cursor no aparesca en el proyecto corriendo, sin embargo este aparece si se presiona ESC
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        //Rotacion horizontal y vertical
        float hor = Input.GetAxis("Mouse X");
        float ver = Input.GetAxis("Mouse Y");

        if (hor != 0)
        {
            transform.Rotate(Vector3.up * hor * sensibility.x);
        }

        if (ver != 0)
        {
            //Esta linea de codigo permite ver todo a 360 pero de manera inestable y fuera de visiones humanas
            //camera.Rotate(Vector3.left * ver * sensibility.y);

            //Este es mas centrado a los angulos de vision y de una persona 
            float angle = (camera.localEulerAngles.x - ver * sensibility.y + 360) % 360;
            if(angle >180)
            {
                angle -= 360;
            }
            angle = Mathf.Clamp(angle, -80, 80);
            camera.localEulerAngles = Vector3.right * angle;
        }
    }
}
