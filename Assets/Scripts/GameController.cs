using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;



public class GameController : MonoBehaviour
{
    public static GameController Instance; // Singleton para acceso global.

    [SerializeField] private int totalNotas = 5; // Total de notas requeridas.
    private int notasRecolectadas = 0;

    [SerializeField] private GameObject salida; // Referencia al objeto de escape.

    // Propiedades para la UI de progreso
    public int NotasRecolectadas => notasRecolectadas; // Notas actuales recolectadas.
    public int TotalNotas => totalNotas; // Total de notas requeridas.

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        // Asegurarse de que la salida esté desactivada al inicio.
        if (salida != null)
        {
            salida.SetActive(false);
        }
    }

    public void AgregarNota()
    {
        notasRecolectadas++;
        UnityEngine.Debug.Log($"Notas recolectadas: {notasRecolectadas}/{totalNotas}");

        // Actualiza la UI de progreso aquí si lo deseas.
        if (notasRecolectadas >= totalNotas)
        {
            ActivarSalida();
        }
    }

    private void ActivarSalida()
    {
        UnityEngine.Debug.Log("¡Todas las notas recolectadas! La salida está activa.");
        if (salida != null)
        {
            salida.SetActive(true); // Activa la salida.
        }
    }
}
