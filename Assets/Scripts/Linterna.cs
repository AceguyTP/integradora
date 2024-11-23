using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Linterna : MonoBehaviour
{
    public Light LuzLinterna;
    private AudioSource audioSource;

    void Start()
    {
        // Obtén el componente AudioSource del objeto actual
        audioSource = GetComponent<AudioSource>();

        if (audioSource != null)
        {
            // Desactiva el loop
            audioSource.loop = false;
        }
        else
        {
            UnityEngine.Debug.LogError("No se encontró un componente AudioSource en este GameObject.");
        }
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Linterna"))
        {
            if (LuzLinterna.enabled == true)
            {
                LuzLinterna.enabled = false;
            }
            else if (LuzLinterna.enabled == false)
            {
                LuzLinterna.enabled = true;
            }
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            audioSource.Play();
        }
    }
}
