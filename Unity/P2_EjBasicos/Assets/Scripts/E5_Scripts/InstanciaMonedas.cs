// Programacion y motores de videojuegos: Salva
//
//
// Scripts C# P2 Ejercicios Unity básicos
//
//
// 11/11/2026
// El primero instancia N monedas (a partir del prefab) en posiciones aleatorias 
// dentro del área definida. El valor de N debe poder modificarse desde el Inspector.
//
//
using UnityEngine;

public class InstanciaMonedas : MonoBehaviour
{
    // [SerializeField] para ser editable desde el inspector
    [SerializeField] GameObject prefabMoneda;
    
    // N monedas por cada clic, puede ser cualquiera
    [SerializeField] int cantidadMonedas = 1;
        
    GameObject contenedor;

    // Zona segura
    float minX = -2.5f;
    float maxX = 2.5f;
    float minZ = -2.5f;
    float maxZ = 2.5f;

    // Altura donde es visible, no varia entre instancias
    float altura = 0.085f;

    void Start()
    {
        contenedor = GameObject.Find("ContenedorMonedas");
    }

    void OnMouseDown()
    {
        // Bucle para instanciar cada moneda
        for (int i = 0; i < cantidadMonedas; i++)
        {
            float posX = Random.Range(minX, maxX);
            float posZ = Random.Range(minZ, maxZ);

            Vector3 posicion = new Vector3(posX, altura, posZ);

            // Instantiate coge cuatro parámetros (objeto a instanciar, lugar donde ponerlo,
            // rotación para asignarle y padre al que va a generar los hijos)
            Instantiate(prefabMoneda, posicion, Quaternion.identity, contenedor.transform);
        }
    }
}