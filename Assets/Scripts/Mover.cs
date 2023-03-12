using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    //Personaje
    //Transform  se utiliza para mover, rotar los objetos 3D
    private float velocidad = 3f;
    public Transform myObjeto;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //movimiento de personaje
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            myObjeto.transform.position += Vector3.left * velocidad * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            myObjeto.transform.position += Vector3.right * velocidad * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            myObjeto.transform.position += Vector3.forward * velocidad * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            myObjeto.transform.position += Vector3.back * velocidad * Time.deltaTime;
        }

    }

    //colisiones
    void OnTriggerEnter(Collider objeto)
    {
        if (objeto.gameObject.tag == "moneda")
        {
            Debug.Log("Choque con la moneda");
        }
        if (objeto.gameObject.tag == "CuboSigno")
        {
            Debug.Log("Choque con Cubo Signo");
        }
        if (objeto.gameObject.tag == "Bloque")
        {
            Debug.Log("Choque con Bloque");
        }
    }
}
