using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    public int Velocidad = 0;
    public float giro = 0;
    public float Horizontal = 0;
    public float vertical = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Horizontal = Input.GetAxis(Horizontal);
        vertical = Input.GetAxis("Vertical");
        //ASIGNAR VELOCIDAD EN EJE Z
        transform.Translate(Vector3.forward * Time.deltaTime * Velocidad * Vertical);
        //ASIGNAR VELOCIDAD EN EJE X
        transform.Translate(Vector3.right * Time.deltaTime * giro * Horizontal);
    }
}
