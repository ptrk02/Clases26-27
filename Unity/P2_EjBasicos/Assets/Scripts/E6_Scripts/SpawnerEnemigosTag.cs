// Programacion y motores de videojuegos: Salva
//
//
// Scripts C# P2 Ejercicios Unity básicos
//
//
// 11/11/2026
// El primero (verde) genera una esfera con el TAG enemigo en una posición aleatoria dentro del área. Cada pulsación genera una esfera.
//
//
using UnityEngine;

public class SpawnerEnemigosTag : MonoBehaviour
{
    [SerializeField] GameObject prefabEnemigo;

    GameObject contenedor;

    int maxEnemigos = 10;

    // Area segura
    float minX = -2.5f;
    float maxX = 2.5f;
    float minZ = -2.5f;
    float maxZ = 2.5f;

    void Start()
    {
        contenedor = GameObject.Find("SpawnerEnemigos");
    }

    void OnMouseDown()
    {
        int cantidadEnemigos = GameObject.FindGameObjectsWithTag("Enemigo").Length; // Compruebo la cantidad de enemigos

        if (cantidadEnemigos >= maxEnemigos) // Si se cumple la condición no hace más de maxEnemigos
        {
            Debug.Log("Se ha alcanzado el máximo de "+ maxEnemigos + " enemigos.");
            return;
        }

        // Generar posición aleatoria
        float posX = Random.Range(minX, maxX);
        float posZ = Random.Range(minZ, maxZ);

        Vector3 posicion = new Vector3(posX, 0.17f, posZ); // Asigna posicion aleatoria

        Instantiate(prefabEnemigo, posicion, Quaternion.identity, contenedor.transform); // Instancia enemigos dentro de un padre
    }
}
