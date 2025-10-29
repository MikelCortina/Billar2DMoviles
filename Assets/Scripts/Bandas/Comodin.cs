using UnityEngine;

public abstract class Comodin : MonoBehaviour
{
    // Aplicar el efecto del comod�n a la bola
    public abstract void Aplicar(GameObject bola);

    // Para saber qu� tipo es visualmente (opcional, �til para debug)
    public abstract Color ObtenerColor();
}
