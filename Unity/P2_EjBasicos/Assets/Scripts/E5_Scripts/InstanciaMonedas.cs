// Programacion y motores de videojuegos: Salva
//
//
// Scripts C# P2 Ejercicios Unity básicos
//
//
// 11/11/2026
// El primero instancia N monedas (a partir del prefab) en posiciones aleatorias dentro del área definida. El valor de N debe poder modificarse desde el Inspector.
//
//
using UnityEngine;

public class InstanciaMonedas : MonoBehaviour
{
    [SerializeField] GameObject prefabMoneda; // [SerializeField] para ser editable desde el inspector
    [SerializeField] int cantidadMonedas = 1; // N monedas por cada clic, puede ser cualquiera
        
    GameObject contenedor;

    // Zona segura
    float minX = -2.5f;
    float maxX = 2.5f;
    float minZ = -2.5f;
    float maxZ = 2.5f;

    float altura = 0.085f; // Altura donde es visible, no varia entre instancias

    void Start()
    {
        contenedor = GameObject.Find("ContenedorMonedas");
    }

    void OnMouseDown()
    {
        for (int i = 0; i < cantidadMonedas; i++) // Bucle para instanciar cada moneda
        {
            float posX = Random.Range(minX, maxX);
            float posZ = Random.Range(minZ, maxZ);

            Vector3 posicion = new Vector3(posX, altura, posZ);

            Instantiate(prefabMoneda, posicion, Quaternion.identity, contenedor.transform); // Instantiate coge cuatro parámetros (objeto a instanciar, lugar donde ponerlo, rotación para asignarle y padre al que va a generar los hijos)
        }
    }
}
