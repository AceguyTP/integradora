using System.Diagnostics;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class LaLlorona : MonoBehaviour
{
    public Transform objetivo; // El jugador (objetivo)
    private NavMeshAgent agente;
    private float contadorTiempo = 25f; // Tiempo en segundos para desaparecer
    private bool jugadorTocado = false; // Para saber si el jugador ha sido tocado
    private GameManager gameManager; // Referencia al GameManager

    private void Awake()
    {
        agente = GetComponent<NavMeshAgent>();
        objetivo = GameObject.FindGameObjectWithTag("Player").transform;
        gameManager = FindObjectOfType<GameManager>(); // Aseguramos que el GameManager está presente

        // Verificamos que el agente esté sobre un NavMesh
        if (!NavMesh.SamplePosition(transform.position, out NavMeshHit hit, 1f, NavMesh.AllAreas))
        {
            UnityEngine.Debug.LogError("LaLlorona no está sobre un NavMesh, por lo que no podrá moverse.");
        }

        // Aseguramos que el jugador está sobre un NavMesh
        if (!NavMesh.SamplePosition(objetivo.position, out NavMeshHit hitJugador, 1f, NavMesh.AllAreas))
        {
            UnityEngine.Debug.LogWarning("El jugador no está sobre un NavMesh. Intentando moverlo a una posición válida.");
            // Mover al jugador a una posición cercana en el NavMesh
            NavMesh.SamplePosition(objetivo.position, out hitJugador, 1f, NavMesh.AllAreas);
            objetivo.position = hitJugador.position;
        }
    }

    private void Update()
    {
        if (!jugadorTocado)
        {
            // Si el jugador no ha sido tocado, contar el tiempo
            contadorTiempo -= Time.deltaTime;

            if (contadorTiempo <= 0f)
            {
                // Si el contador llega a 0, destruir al enemigo
                gameManager.CrearNuevoSlender(); // Crear un nuevo Slender
                Destroy(gameObject); // Destruir el Slender actual
                UnityEngine.Debug.Log("El Slender ha desaparecido después de 10 segundos sin tocar al jugador.");
            }
            else
            {
                // Aseguramos que el agente esté en un NavMesh antes de darle un destino
                if (NavMesh.SamplePosition(objetivo.position, out NavMeshHit hit, 1f, NavMesh.AllAreas))
                {
                    // Si el objetivo está sobre un NavMesh, asignamos el destino
                    agente.SetDestination(objetivo.position);
                }
                else
                {
                    // Si el objetivo no está sobre un NavMesh, simplemente no mover al agente
                    UnityEngine.Debug.LogError("El objetivo (jugador) no está sobre un NavMesh. No se puede asignar el destino.");
                }
            }
        }
        else
        {
            // Si el jugador fue tocado, reiniciar el contador
            contadorTiempo = 10f;
            jugadorTocado = false; // Restablecer la variable
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // El jugador ha sido tocado, detener el contador
            jugadorTocado = true;
            UnityEngine.Debug.Log("Mamaste.");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    public void IniciarContadorTiempo()
    {
        // Este método es llamado por el GameManager cuando se crea un nuevo Slender
        contadorTiempo = 10f; // Restablecer el contador
        jugadorTocado = false; // Asegurarse de que no esté tocado al principio
    }
}
