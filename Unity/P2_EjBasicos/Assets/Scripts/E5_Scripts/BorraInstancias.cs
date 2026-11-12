// Programacion y motores de videojuegos: Salva
//
//
// Scripts C# P2 Ejercicios Unity básicos
//
//
// 11/11/2026
// El segundo destruye todas las monedas que haya
// en la escena en ese momento.
//
//
using UnityEngine;

public class BorraInstancias : MonoBehaviour
{
    GameObject contenedor;

    void Start()
    {
        contenedor = GameObject.Find("ContenedorMonedas");
    }

    void OnMouseDown()
    {
        foreach (Transform moneda in contenedor.transform)
        {
            // Destroy() borra del hierarchy el objeto (solo en Play Mode)
            Destroy(moneda.gameObject);
        }
    }
}