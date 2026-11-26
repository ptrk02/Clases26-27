using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    GameObject esfera;
    GameObject cubo;

    Vector3 posicionInicial;

    // Start is called before the first frame update
    void Start()
    {
        esfera = GameObject.Find("Esfera");

        posicionInicial = new Vector3 (0, 0, 0);
        esfera.transform.position = posicionInicial;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 posicion = esfera.transform.position;

        float posicionX = posicion.x;
        float posicionY = posicion.y;
        float posicionZ = posicion.z;

        posicionX++;

        Vector3 nuevaPosicion = new Vector3(posicionX, posicionY, posicionZ);

        esfera.transform.position = nuevaPosicion;

        

        Debug.Log(posicion);
    }




}
