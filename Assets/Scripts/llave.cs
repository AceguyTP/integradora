using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class llave : MonoBehaviour
{
    public GameObject Objetollave;
    public GameObject Colliderpuerta;

        void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                Colliderpuerta.gameObject.SetActive(true);
                Destroy(Objetollave);
            }
        }
}
