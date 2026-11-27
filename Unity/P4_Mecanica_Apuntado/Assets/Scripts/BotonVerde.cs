using UnityEngine;

public class BotonVerde : MonoBehaviour
{
    public Canyon canyon;

    void OnMouseDown()
    {
        // Disparamos al pulsar el boton verde.
        canyon.Disparar();
    }
}
