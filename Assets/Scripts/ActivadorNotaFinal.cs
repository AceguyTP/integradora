using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivadorNotaFinal : MonoBehaviour
{
    public GameObject pickUpText;
    public GameObject notaVisual;
    public bool activa;

    void Start()
    {
        pickUpText.SetActive(false);
    }

    // Update is called once per frame
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            pickUpText.SetActive(true);

            if (Input.GetKeyDown(KeyCode.E) && activa == true)
            {
                notaVisual.SetActive(true);
                pickUpText.SetActive(false );
            }
        }
        if (Input.GetKeyDown(KeyCode.Escape) && activa == true)
        {
            notaVisual.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            activa = true;
            pickUpText.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            activa = false;
            notaVisual.SetActive(false);
            pickUpText.SetActive(false);
        }
    }
}
