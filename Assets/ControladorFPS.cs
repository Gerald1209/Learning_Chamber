using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorFPS : MonoBehaviour
{
    [Tooltip("Velocidad de Movimiento del personaje en m/s")]
    [Range(0,10)]
    public float speed;

    [Tooltip("Velocidad de rotacion")]
    [Range(0,360)]
    public float rotationSpeed;

    // Update is called once per frame
    void Update()
    {
        float space = speed * Time.deltaTime;

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(horizontal, 0, vertical);
        transform.Translate(dir.normalized*space);

        float angle = rotationSpeed * Time.deltaTime;
        float mouseX = Input.GetAxis("Mouse X");       
        transform.Rotate(0, mouseX * angle, 0);
    }
    
}
