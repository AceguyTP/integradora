using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abrirultimapuerta : MonoBehaviour
{
    public Animator animator;
    public GameObject audiopuerta;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        animator.Play("Abrir");
        audiopuerta.SetActive(true);
        Destroy(gameObject);
    }
}
