using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SC_DialogoManager : MonoBehaviour
{
    public TMP_Text textoDialogo;

    private string[] dialogos;

    private int indiceActual;

    private void Start()
    {
        dialogos = new string[]
        {
            "Diálogo 1",
            "Diálogo 2",
            "Diálogo 3"
        };

        indiceActual = 0;

        textoDialogo.text = dialogos[indiceActual];
    }

    public void MostrarSiguienteDialogo()
    {
        indiceActual++;

        if (indiceActual < dialogos.Length)
        {
            textoDialogo.text = dialogos[indiceActual];
        }
        else
        {
            textoDialogo.text = "Fin del diálogo";
        }
    }
}

