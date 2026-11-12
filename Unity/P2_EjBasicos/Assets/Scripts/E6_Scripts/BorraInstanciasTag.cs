// Programacion y motores de videojuegos: Salva
//
//
// Scripts C# P2 Ejercicios Unity básicos
//
//
// 11/11/2026
// El segundo (rojo) destruye todas las esferas que tengan el TAG enemigo.
//
// Foro de referencia: 
// https://discussions.unity.com/t/editor-script-how-to-clear-the-console-output-window/1161
//
using System;
using UnityEngine;
using System.Reflection;
using UnityEditor;

public class BorraInstanciasTag : MonoBehaviour
{
    void OnMouseDown()
    {
        // Recorro todos los GamObjects con Flag de "Enemigo"
        foreach (GameObject enemigo in GameObject.FindGameObjectsWithTag("Enemigo"))
        {
            Destroy(enemigo); // Destroy() borra del hierarchy el objeto (solo en Play Mode)
            ClearLog(); // Borra el debug log *Mejora estética*
        }
    }

    // Función sacada de un foro de discusión. Útil para convertir en snippet,
    // usa varias dependencias para funcionar...
    void ClearLog()
    {
        Assembly assembly = Assembly.GetAssembly(typeof(SceneView));

        Type type = assembly.GetType("UnityEditor.LogEntries");
        MethodInfo method = type.GetMethod("Clear");
        method.Invoke(new object(), null);
    }
}