using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class llorona : MonoBehaviour
{
    public GameObject audiollorona;
    public GameObject algo;
    // Start is called before the first frame update
    void Start()
    {
        audiollorona.SetActive(false);
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            audiollorona.SetActive(true);
            Destroy(algo);
        }
    }
}
