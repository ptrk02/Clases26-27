// Programacion y motores de videojuegos: Salva
//
//
// Scripts C# P2 Ejercicios Unity básicos
//
//
// 11/11/2026
// El primero (botón rojo FILA) calcula una posición aleatoria y válida para el primer hijo y coloca el resto de hijos en fila (uno a continuación del otro, con una separación fija entre ellos).
//
//
using UnityEngine;

public class PosicionarEnFila : MonoBehaviour
{
    GameObject contenedor;

    // Area segura
    float minX = -8f;
    float maxX = 8f;
    float minZ = -8f;
    float maxZ = 8f;

    float separacion = 1.25f; // Puede ser cualquiera, pero esta queda bien

    void Start()
    {
        contenedor = GameObject.Find("PadreVacio");
    }

    void OnMouseDown()
    {
        int cantidadHijos = contenedor.transform.childCount; // Conseguir numero de hijos

        // Calcular el espacio total necesario
        float longitudFila = (cantidadHijos - 1) * separacion;

        // Posición aleatoria para el primer hijo dentro del rango del espacio necesario
        float posX = Random.Range(minX, maxX - longitudFila);
        float posZ = Random.Range(minZ, maxZ);

        for (int i = 0; i < cantidadHijos; i++) // Colocar cada hijo en fila a partir del primero
        {
            Transform hijo = contenedor.transform.GetChild(i);

            Vector3 posicion = hijo.position;

            posicion.x = posX + (i * separacion);
            posicion.z = posZ;

            hijo.position = posicion;
        }
    }
}
