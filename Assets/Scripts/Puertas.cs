using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puertas : MonoBehaviour
{
    public GameObject audiollorona;
    public GameObject algo;
    public GameObject puerta;
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
            gameObject.SetActive(false);
            UnityEngine.Debug.Log("Has recogido la llave.");
            audiollorona.SetActive(true);
            puerta.gameObject.SetActive(true);
            Destroy(algo);
        }
    }
}
