// Programacion y motores de videojuegos: Salva
//
//
// Scripts C# P2 Ejercicios Unity básicos
//
//
// 09/11/2026
// La cruceta blanca mueve la esfera 1 unidad en la dirección del botón
//
//
using UnityEngine;

public class MovimientoIzquierda: MonoBehaviour
{
    GameObject bola;

    void Start()
    {
        bola = GameObject.Find("Bola");
    }

    void Update()
    {
        
    }

    void OnMouseDown()
    {
        Debug.Log("Clic");

        float posX = bola.transform.position.x;
        float posY = bola.transform.position.y;
        float posZ = bola.transform.position.z;

        if (posX - 1 <= -4f) // Limite de posicion en Y
        {
            posX = -4f;
        }

        bola.transform.position = new Vector3(posX -1, posY, posZ);
    }
}

