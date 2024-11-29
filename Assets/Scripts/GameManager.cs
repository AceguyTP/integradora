using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject slender; // Prefab de Slender
    [SerializeField] Transform[] arrayPuntosSalida; // Puntos aleatorios donde puede aparecer Slender

    private int puntoSalida; // Índice para seleccionar el punto de salida

    public void CrearNuevoSlender()
    {
        // Elegir un punto aleatorio para el nuevo Slender
        puntoSalida = UnityEngine.Random.Range(0, arrayPuntosSalida.Length);

        // Instanciar el nuevo Slender en el punto seleccionado
        Instantiate(slender, arrayPuntosSalida[puntoSalida].position, Quaternion.identity);
    }
}
