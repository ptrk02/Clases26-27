// Programacion y motores de videojuegos: Salva
//
//
// Scripts C# P2 Ejercicios Unity básicos
//
//
// 09/11/2026
// La cruceta blanca mueve la esfera 1 unidad en la dirección del botón (haz solo arriba e izquierda)
//
//
using UnityEngine;

public class MovimientoArriba: MonoBehaviour
{
    GameObject bola;

    void Start()
    {
        bola = GameObject.Find("Bola"); // Busca por nombre GameObject en Hierarchy
    }

    void OnMouseDown()
    {
        // Creamos variables locales de position
        float posX = bola.transform.position.x;
        float posY = bola.transform.position.y;
        float posZ = bola.transform.position.z;

        if (posY - 1 < 1.5f) // Limite de posicion en Y
        {
            posY = 1.5f;
        }

        bola.transform.position = new Vector3(posX, posY +1, posZ); // Asignamos los componentes de position a bola
    }
}

