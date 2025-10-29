using UnityEngine;

public class CPuntosExtra : Comodin
{
    public int puntosExtra = 1;

    public override void Aplicar(GameObject bola)
    {
        // Aqu� deber�as tener una referencia a alg�n sistema de puntuaci�n
        Debug.Log("Se aplican " + puntosExtra + " puntos extra");
        // Ejemplo: GameManager.Instance.A�adirPuntos(puntosExtra);
    }

    public override Color ObtenerColor()
    {
        return Color.yellow;
    }
}
