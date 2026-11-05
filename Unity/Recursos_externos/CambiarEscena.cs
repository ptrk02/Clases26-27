using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarEscena : MonoBehaviour
{
    BaseDatosGlobal baseDeDatos;

    // Start is called before the first frame update
    void Start()
    {
        baseDeDatos = GameObject.Find("PersistenceManager").GetComponent<BaseDatosGlobal>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "PERSONAJE")
        {
            baseDeDatos.escena1Completada = true;
            SceneManager.LoadScene("MENU-PRINCIPAL");
        }
    }
}
