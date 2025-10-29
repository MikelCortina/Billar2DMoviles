using UnityEngine;

public class CMultiplicador : Comodin
{
    public override void Aplicar(GameObject bola)
    {
        // Este comod�n no aplica un efecto directo aqu�, el efecto es evaluado desde Banda
        Debug.Log("Comod�n multiplicador activo. Efectos x2");
    }

    public override Color ObtenerColor()
    {
        return Color.magenta;
    }
}
