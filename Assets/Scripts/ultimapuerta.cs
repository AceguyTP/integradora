using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ultimapuerta : MonoBehaviour
{
    public GameObject algo;
    public GameObject puerta;
    // Start is called before the first frame update

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameObject.SetActive(false);
            UnityEngine.Debug.Log("Ha salido al llorona.");
            puerta.gameObject.SetActive(true);
            Destroy(algo);
        }
    }
}
