using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement; // Para cargar una nueva escena al escapar.

public class Escape : MonoBehaviour
{ // Nombre de la escena de escape.

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            UnityEngine.Debug.Log("¡Escapaste del bosque!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2); // Carga la escena de escape.
        }
    }
}

