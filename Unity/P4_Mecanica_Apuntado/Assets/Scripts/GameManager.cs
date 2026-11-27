using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Transform cruceta;
    public float velocidad = 5f;
    public float limiteX = 5f;
    public float limiteY = 3f;

    public GameObject prefabDiana;
    public Transform[] posicionesDianas = new Transform[5];

    Vector3 posicionInicial;

    void Start()
    {
        // Guardamos la posicion inicial de la cruceta.
        posicionInicial = cruceta.position;
        GenerarDiana();
    }

    void Update()
    {
        Vector3 posicion = cruceta.position;
        float posicionX = posicion.x;
        float posicionY = posicion.y;
        float posicionZ = posicionInicial.z;

        // Movemos la cruceta con WASD.
        if (Input.GetKey(KeyCode.A)) posicionX -= velocidad * Time.deltaTime;
        if (Input.GetKey(KeyCode.D)) posicionX += velocidad * Time.deltaTime;
        if (Input.GetKey(KeyCode.W)) posicionY += velocidad * Time.deltaTime;
        if (Input.GetKey(KeyCode.S)) posicionY -= velocidad * Time.deltaTime;

        // Limitamos el movimiento en X e Y.
        posicionX = Mathf.Clamp(posicionX, posicionInicial.x - limiteX, posicionInicial.x + limiteX);
        posicionY = Mathf.Clamp(posicionY, posicionInicial.y - limiteY, posicionInicial.y + limiteY);

        Vector3 nuevaPosicion = new Vector3(posicionX, posicionY, posicionZ);
        cruceta.position = nuevaPosicion;
    }

    public void GenerarDiana()
    {
        // Elegimos una de las cinco posiciones al azar.
        int numero = Random.Range(0, posicionesDianas.Length);
        Transform posicion = posicionesDianas[numero];

        GameObject diana = Instantiate(prefabDiana, posicion.position, posicion.rotation);
        diana.GetComponent<Diana>().gameManager = this;
    }
}
