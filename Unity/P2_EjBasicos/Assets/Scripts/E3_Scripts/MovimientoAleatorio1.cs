// Programacion y motores de videojuegos: Salva
//
//
// Scripts C# P2 Ejercicios Unity básicos
//
//
// 10/11/2026
// El primero mueve en alguna dirección aleatoria a cada uno de los hijos.
// El movimiento es de 1 unidad.
//
//
using UnityEngine;

public class MovimientoAleatorio1 : MonoBehaviour
{
    GameObject contenedor;

    void Start()
    {
        contenedor = GameObject.Find("PadreVacio");
    }

    void OnMouseDown()
    {
        // Recorre todos los hijos directos del padre
        foreach (Transform hijo in contenedor.transform)
        {
            // Genera una dirección aleatoria en 3D con longitud exactamente 1
            Vector3 direccion = Random.onUnitSphere;

            // Desplaza cada objeto una unidad desde su posición actual
            hijo.position += direccion;
        }
    }
}