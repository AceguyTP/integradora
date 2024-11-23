using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abrepuerta : MonoBehaviour
{
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
            animator.Play("Abrir");
            audiopuerta.SetActive(true);
            Destroy(gameObject);
        }
    }
}
