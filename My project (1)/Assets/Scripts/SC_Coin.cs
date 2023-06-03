using UnityEngine;

public class Coin : MonoBehaviour
{
    public int coinValue = 10; // Valor de la moneda
    public AudioClip coinSound; // Sonido al recoger la moneda

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Sumar puntos al jugador
            SC_GroundGenerator.instance.score += coinValue;

            // Reproducir sonido de recoger moneda
            AudioSource.PlayClipAtPoint(coinSound, transform.position);

            // Desactivar la moneda
            gameObject.SetActive(false);
        }
    }
}
