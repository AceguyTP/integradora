using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puerta : MonoBehaviour
{
    public string nombreAnimacion;
    public Animator animator;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            animator.Play("abrir");
            Destroy(gameObject);
        }
    }
}
