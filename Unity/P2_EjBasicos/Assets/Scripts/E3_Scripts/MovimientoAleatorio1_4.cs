// Programacion y motores de videojuegos: Salva
//
//
// Scripts C# P2 Ejercicios Unity básicos
//
//
// 10/11/2026
// El segundo mueve X unidades en alguna dirección aleatoria a cada uno
// de los hijos. La X es una valor aleatorio entre 1 y 4.
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
        // Recorre todos los hijos directos del padre
        foreach (Transform hijo in contenedor.transform)
        {
            // Genera una dirección aleatoria en 3D con longitud exactamente 1,
            // luego multiplica su valor por número aleatrorio; 1 entre 4.
            Vector3 direccion = Random.onUnitSphere * Random.Range(1f, 5f);

            // desplaza cada objeto una unidad desde su posición actual
            hijo.position += direccion;
        }
    }
}