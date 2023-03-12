using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TomarObjeto : MonoBehaviour
{

    public GameObject objetoPoint;
    public GameObject pickObject = null;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (pickObject != null)
        {
            if( Input.GetKey("r"))
            {
                pickObject.GetComponent<Rigidbody>().useGravity = true;

                pickObject.GetComponent<Rigidbody>().isKinematic = false;
                pickObject.gameObject.transform.SetParent(null);
                pickObject = null;
            }
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Arma"))
        {
            Debug.Log("Si puso Arma");
            if (Input.GetKey("e") && pickObject == null)
            {

                other.GetComponent<Rigidbody>().useGravity = false;
                pickObject.GetComponent<Rigidbody>().isKinematic = true;
                other.transform.position = objetoPoint.transform.position;
                other.gameObject.transform.SetParent(objetoPoint.gameObject.transform);
                pickObject = other.gameObject;
                pickObject.transform.Rotate(0, 180f, 0);
            }
        }
    }
}
