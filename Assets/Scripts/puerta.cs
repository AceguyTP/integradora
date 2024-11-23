using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puerta : MonoBehaviour
{
    public string nombreAnimacion;
    public Animator animator;
    public GameObject audiopuerta;

    void Start()
    {
       audiopuerta.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            animator.Play("abrir");
            audiopuerta.SetActive(true);
            Destroy(gameObject);
        }
    }
}
