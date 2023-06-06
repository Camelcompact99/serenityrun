//SCRIPT PARA CONTROLAR LOS DIALOGOS :P 


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;
using TMPro;



public class SC_DialogoManager : MonoBehaviour
{
    public TMP_Text textoDialogo;

    private string[] dialogos;

    private int indiceActual;

    private void Start()
    {
        //creamos un array de strings que contenga todos los textos que queremos que se sucedan 
        dialogos = new string[]
        {
            "Aquí no se trata de perder, sino de abrazar la repetición.",
            "¡Oh, mira, otra nube! ¡Definitivamente no hemos tenido suficiente!",
            "...¿nos estamos divirtiendo? ¡Claro, si disfrutas de lo mismo una y otra vez!",
            "Intenta hacer un Speedrun... ¡a ver dale!",
            "Sigue adelante, porque claramente no hay otra opción.",
            "¡La emoción no tiene límites... porque no hay emoción en absoluto!",
            "Eres un verdadero experto en hacer lo mismo",
            "Sigues en esta maravillosa monotonía relajante",
            "Tu determinación es asombrosa... en seguir adelante sin sentido",
            "No hay nadie que pueda detenerte... porque nadie más está jugando",
            "Como contar ovejas en un sueño que nunca termina.",
            "Has ganado otro punto más en tu búsqueda infinita",
            "El único límite en este juego es tu propia paciencia",
            "Una vida sin preocupaciones... y ninguna emoción real",
        };

        indiceActual = 0;

        textoDialogo.text = dialogos[indiceActual];
    }
//esta función nos muestra el siguiente dialogo del array 
    public void MostrarSiguienteDialogo()
    {
        indiceActual++;

        if (indiceActual < dialogos.Length)
        {
            textoDialogo.text = dialogos[indiceActual];
        }
        else
        {
            textoDialogo.text = dialogos[1];
        }
    }
}

