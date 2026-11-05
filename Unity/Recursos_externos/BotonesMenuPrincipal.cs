using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class BotonesMenuPrincipal : MonoBehaviour
{
    BaseDatosGlobal baseDeDatos;

    Button          botonEscena1;
    TextMeshProUGUI escena1Completada;


    Button          botonEscena2;
    TextMeshProUGUI escena2Completada;


    // Start is called before the first frame update
    void Start()
    {
        botonEscena1      = GameObject.Find("Escena1").GetComponent<Button>();
        escena1Completada = GameObject.Find("ProgresoEscena1").GetComponent<TextMeshProUGUI>();
        baseDeDatos       = GameObject.Find("PersistenceManager").GetComponent<BaseDatosGlobal>();

        if (baseDeDatos.escena1Completada == true)
        {
            escena1Completada.text = "Superada";
            botonEscena1.interactable = false;
        }

        escena2();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CambiarEscenaPlataformas()
    {
        SceneManager.LoadScene("PLATAFORMAS-ANIMACION");
    }

    public void CambiarEscenaCamaras()
    {
        SceneManager.LoadScene("TEST-CAMARAS");
    }

    public void ResetearPreferencias()
    {
        PlayerPrefs.DeleteAll();

        escena1Completada.text = "No Superada";
        botonEscena1.interactable = true;

        escena2Completada.text = "No Superada";
        botonEscena2.interactable = true;
    }

    void escena2()
    {
        botonEscena2 = GameObject.Find("Escena2").GetComponent<Button>();
        escena2Completada = GameObject.Find("ProgresoEscena2").GetComponent<TextMeshProUGUI>();

      

        if (PlayerPrefs.GetInt("nivel2") == 1)
        {
            escena2Completada.text = "Superada";
            botonEscena2.interactable = false;
        }
    }
}
