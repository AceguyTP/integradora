using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ProgresoNotas : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textoProgreso; // Texto en la UI.

    private void Update()
    {
        textoProgreso.text = $"Notas: {GameController.Instance.NotasRecolectadas}/{GameController.Instance.TotalNotas}";
    }
}
