// Programacion y motores de videojuegos: Salva
//
//
// Scripts C# P2 Ejercicios Unity básicos
//
//
// 09/11/2026
// La cruceta blanca mueve la esfera 1 unidad en la dirección del botón
//
//
using UnityEngine;

public class ActivarDesactivar: MonoBehaviour
{
    GameObject bola;

    void Start()
    {
        bola = GameObject.Find("Bola");
    }

    void Update()
    {
        
    }

    void OnMouseDown()
    {
        Debug.Log("Clic");

        bola.transform.position = new Vector3(0, 1, 0);
    }
}

