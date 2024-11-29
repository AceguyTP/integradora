using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pantallaescape : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Hacer visible el cursor
        Cursor.lockState = CursorLockMode.None; // Desbloquea el cursor.
        Cursor.visible = true; // Muestra el cursor.
    }

    public void Menu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
    }

    // Update is called once per frame
    public void Salir()
    {
        UnityEngine.Debug.Log("Salir...");
        UnityEngine.Application.Quit();
    }
}
