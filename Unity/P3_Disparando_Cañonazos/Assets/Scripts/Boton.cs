using UnityEngine;

public class Boton : MonoBehaviour
{
    public Canon canon;

    public enum TipoBoton
    {
        Verde,
        Rojo,
        Blanco
    }

    public TipoBoton tipo;

    void OnMouseDown()
    {
        // Ejecutar función del botón
        switch (tipo)
        {
            case TipoBoton.Verde:
                canon.Disparar();
                break;

            case TipoBoton.Rojo:
                canon.EliminarBalas();
                break;

            case TipoBoton.Blanco:
                canon.DisparoAleatorio();
                break;
        }
    }
}