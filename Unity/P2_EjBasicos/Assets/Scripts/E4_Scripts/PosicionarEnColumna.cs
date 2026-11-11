// Programacion y motores de videojuegos: Salva
//
//
// Scripts C# P2 Ejercicios Unity básicos
//
//
// 11/11/2026
// El segundo (botón verde COLUMNA) hace lo mismo, pero colocando los hijos en columna.
//
//
using UnityEngine;

public class PosicionarEnColumna : MonoBehaviour
{
    GameObject contenedor;

    float minX = -8f;
    float maxX = 8f;
    float minZ = -8f;
    float maxZ = 8f;

    float separacion = 1.25f;

    void Start()
    {
        contenedor = GameObject.Find("PadreVacio");
    }

    void OnMouseDown()
    {
        int cantidadHijos = contenedor.transform.childCount; // Conseguir numero de hijos

        // Calcular el espacio total necesario
        float longitudColumna = (cantidadHijos - 1) * separacion;

        // Posición aleatoria para el primer hijo dentro del rango del espacio necesario
        float posX = Random.Range(minX, maxX);
        float posZ = Random.Range(minZ, maxZ - longitudColumna);

        for (int i = 0; i < cantidadHijos; i++) // Colocar cada hijo en fila a partir del primero
        {
            Transform hijo = contenedor.transform.GetChild(i);

            Vector3 posicion = hijo.position;

            posicion.x = posX;
            posicion.z = posZ + (i * separacion);

            hijo.position = posicion;
        }
    }
}
