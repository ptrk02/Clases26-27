using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseDatosGlobal : MonoBehaviour
{
    public bool escena1Completada; // NOS SERVIRÁ PARA SABER SI LA ESCENA 1 ESTÁ COMPLETADA O NO
                                    // false --> escena1 no completada
                                    // true  --> escena1 completada

    // ..

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        GameObject persistenceManager = GameObject.Find("PersistenceManager");

        DontDestroyOnLoad(persistenceManager);

        escena1Completada = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
