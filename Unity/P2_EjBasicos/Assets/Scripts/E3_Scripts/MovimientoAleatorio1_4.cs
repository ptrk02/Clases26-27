// Programacion y motores de videojuegos: Salva
//
//
// Scripts C# P2 Ejercicios Unity básicos
//
//
// 10/11/2026
// El segundo mueve X unidades en alguna dirección aleatoria a cada uno de los hijos. La X es una valor aleatorio entre 1 y 4.
//
//
using UnityEngine;

public class MovimientoAleatorio1_4 : MonoBehaviour
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
            Vector3 direccion = Random.onUnitSphere * Random.Range(1f, 5f); // genera una dirección aleatoria en 3D con longitud exactamente 1, luego multiplica su valor por número aleatrorio; 1 entre 4

            hijo.position += direccion; // desplaza cada objeto una unidad desde su posición actual
        }
    }
}
