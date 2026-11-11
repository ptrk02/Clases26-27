// Programacion y motores de videojuegos: Salva
//
//
// Scripts C# P2 Ejercicios Unity básicos
//
//
// 09/11/2026
// El cuadrado negro lo activa y desactiva.
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

    void OnMouseDown()
    {
        // Asignamos la inversa del parámetro que devuelve el metodo activeSelf de bola. 
        // activeSelf es un método que comprueba si un objeto está activo en la escena.
        bola.SetActive(!bola.activeSelf);
    }
}