using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pasos : MonoBehaviour
{
    public AudioSource sonidopasos;
    public AudioSource corrida;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                sonidopasos.enabled = false;
                corrida.enabled = true;
            }
            else
            {
                sonidopasos.enabled = true;
                corrida.enabled = false;
            }
        }
        else
        {
            sonidopasos.enabled = false;
            corrida.enabled = false;
        }
    }
}
