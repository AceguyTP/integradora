using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diario : MonoBehaviour
{
    public GameObject diario;
    public GameObject pickUpText;
    public GameObject arbol;
    public GameObject arbol1;
    public GameObject arbol2;
    public GameObject arbol3;
    public GameObject arbol4;
    public GameObject Contador;
    public GameObject MensajeDiario;
    public float tiempoMensaje = 5;
    public GameObject audiodiario;

    void Start()
    {
        pickUpText.SetActive(false);
        audiodiario.SetActive(false);

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
                UnityEngine.Debug.Log("Has recogido el diairo.");
                arbol.gameObject.SetActive(true);
                arbol1.gameObject.SetActive(true);
                arbol2.gameObject.SetActive(true);
                arbol3.gameObject.SetActive(true);
                arbol4.gameObject.SetActive(true);
                Contador.gameObject.SetActive(true);
                audiodiario.SetActive(true);
                Destroy(diario);
                pickUpText.SetActive(false);
                MensajeDiario.SetActive(true);
            }
        }
    }

    void Update()
    {
        tiempoMensaje -= Time.deltaTime;
        if (tiempoMensaje <= 0)
        {
            MensajeDiario.SetActive(false);
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
