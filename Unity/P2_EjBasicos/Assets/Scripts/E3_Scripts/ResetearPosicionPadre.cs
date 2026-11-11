// Programacion y motores de videojuegos: Salva
//
//
// Scripts C# P2 Ejercicios Unity básicos
//
//
// 10/11/2026
// El cuarto (rojo) los resetea a la posición inicial.
//
//
using UnityEngine;

public class ResetearPosicionPadre: MonoBehaviour
{
    GameObject contenedor;
    Transform[] hijos;
    Vector3[] posicionesIniciales;

    void Start()
    {
        contenedor = GameObject.Find("PadreVacio");

        // Obtener cantidad de hijos usando childCount
        int cantidadHijos = contenedor.transform.childCount;

        hijos = new Transform[cantidadHijos];
        posicionesIniciales = new Vector3[cantidadHijos];

        // Guardar los hijos y sus posiciones iniciales
        for (int i = 0; i < cantidadHijos; i++)
        {
            hijos[i] = contenedor.transform.GetChild(i);
            posicionesIniciales[i] = hijos[i].position;
        }
    }

    void OnMouseDown()
    {
        for (int i = 0; i < hijos.Length; i++)
        {
            // Restaurar la posición de cada hijo
            hijos[i].position = posicionesIniciales[i];
        }
    }
}