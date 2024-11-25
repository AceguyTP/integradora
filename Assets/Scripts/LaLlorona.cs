using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.AI;

public class LaLlorona : MonoBehaviour
{
    public Transform objetivo;
    private NavMeshAgent agente;

    // Start is called before the first frame update
    private void Awake()
    {
        agente = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    private void Update()
    {
        agente.SetDestination(objetivo.position);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Application.Quit();
        }
    }

}
