// Programacion y motores de videojuegos: Salva
//
//
// Scripts C# P2 Ejercicios Unity básicos
//
//
// 09/11/2026
// La cruceta verde mueve la esfera 3 unidades en la dirección del botón (haz solo abajo y derecha).
//
//
using UnityEngine;

public class MovimientoDerecha: MonoBehaviour
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

        if (posX + 1 >= +4f) // Limite de posicion en X
        {
            posX = +4f;
        }

        bola.transform.position = new Vector3(posX +3, posY, posZ);
    }
}

