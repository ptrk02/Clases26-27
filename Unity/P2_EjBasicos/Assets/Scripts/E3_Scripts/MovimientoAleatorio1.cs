// Programacion y motores de videojuegos: Salva
//
//
// Scripts C# P2 Ejercicios Unity básicos
//
//
// 10/11/2026
// El primero mueve en alguna dirección aleatoria a cada uno de los hijos. El movimiento es de 1 unidad.
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
        foreach (Transform hijo in contenedor.transform) //  recorre todos los hijos directos del padre
        {
            Vector3 direccion = Random.onUnitSphere; // genera una dirección aleatoria en 3D con longitud exactamente 1

            hijo.position += direccion; // desplaza cada objeto una unidad desde su posición actual
        }
    }
}
