using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nota : MonoBehaviour
{
    public AudioClip soundRecolectar; // Opcional, sonido al recolectar la nota.

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Asegúrate de que el Player tiene el tag "Player".
        {
            if (soundRecolectar != null)
            {
                AudioSource.PlayClipAtPoint(soundRecolectar, transform.position);
            }

            GameController.Instance.AgregarNota(); // Notifica al GameManager.
            Destroy(gameObject); // Destruye la nota tras recogerla.
        }
    }
}

