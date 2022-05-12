using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorFPS : MonoBehaviour
{

    Rigidbody rb;
    Vector2 inputMov;
    public float velCamina = 10f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //leemos el input
        inputMov.x = Input.GetAxis("Horizontal");
        inputMov.y = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        float vel = velCamina;
        rb.velocity = transform.forward * vel * inputMov.y // Movernos a adelante
        + transform.right * vel * inputMov.x; //Movernos a los lados
    }
}
