using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static System.Net.Mime.MediaTypeNames;

public class pantalladerrota : MonoBehaviour
{

    void Start()
    {
        // Hacer visible el cursor
        Cursor.lockState = CursorLockMode.None; // Desbloquea el cursor.
        Cursor.visible = true; // Muestra el cursor.
    }

    // Start is called before the first frame update
    public void Menu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }

    // Update is called once per frame
    public void Salir()
    {
        UnityEngine.Debug.Log("Salir...");
        UnityEngine.Application.Quit();
    }
}
