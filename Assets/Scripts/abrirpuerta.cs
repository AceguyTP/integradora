using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class abrirpuerta : MonoBehaviour
{
    public GameObject Objetollave;
    public GameObject pickUpText;
    public GameObject Colliderpuerta;
    public GameObject MensajeLlave;
    public float tiempoMensaje = 5;
    public GameObject audiollave;

    void Start()
    {
        pickUpText.SetActive(false);
        audiollave.SetActive(false);
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            pickUpText.SetActive(true);
            // Check if 'E' key is held down to pick up the Block
            if (Input.GetKey(KeyCode.E))
            {
                gameObject.SetActive(false);
                UnityEngine.Debug.Log("Has recogido la llave.");
                Colliderpuerta.gameObject.SetActive(true);
                audiollave.SetActive(true);
                Destroy(Objetollave);
                pickUpText.SetActive(false);
                MensajeLlave.SetActive(true);        
            }
        }
    }

    void Update()
    {
        tiempoMensaje -= Time.deltaTime;
        if (tiempoMensaje <= 0)
        {
            MensajeLlave.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            pickUpText.SetActive(false);
        }
    }
}
