// Programacion y motores de videojuegos: Salva
//
//
// Scripts C# P2 Ejercicios Unity básicos
//
//
// 10/11/2026
// Un cuadrado rojo resetea todos los cubos y esferas a su posición inicial.
// PD: Recorremos varios tags duplicando código, habrían mejores maneras de hacerlo.
//

using UnityEngine;

public class ReseteaPosicionTag : MonoBehaviour
{
    GameObject[] bolas;
    GameObject[] cubos;
    Vector3[] posicionesInicialesEsfera;
    Vector3[] posicionesInicialesCubo;

    void Start()
    {
        // Buscar todos los objetos con el Tag
        bolas = GameObject.FindGameObjectsWithTag("Esfera");
        cubos = GameObject.FindGameObjectsWithTag("Cubo");

        // Crear un array para guardar sus posiciones iniciales
        posicionesInicialesEsfera = new Vector3[bolas.Length];
        posicionesInicialesCubo = new Vector3[cubos.Length];

        // Guardo la posición inicial de cada objeto
        for (int i = 0; i < bolas.Length; i++)
        {
            posicionesInicialesEsfera[i] = bolas[i].transform.position;
        }
        for (int i = 0; i < cubos.Length; i++)
        {
            posicionesInicialesCubo[i] = cubos[i].transform.position;
        }
    }

    void OnMouseDown()
    {
        // Restauro las posiciones iniciales de los gameObjects de las dos Tags
        for (int i = 0; i < bolas.Length; i++)
        {
            bolas[i].transform.position = posicionesInicialesEsfera[i];
        }
        for (int i = 0; i < cubos.Length; i++)
        {
            cubos[i].transform.position = posicionesInicialesCubo[i];
        }
    }
}