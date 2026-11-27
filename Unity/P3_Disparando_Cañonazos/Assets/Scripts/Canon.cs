using UnityEngine;
using TMPro;

public class Canon : MonoBehaviour
{
    public GameObject prefabBala;
    public Transform puntoDisparo;
    public TextMeshProUGUI contador;

    public float fuerza = 15f;
    public float distancia = 3f;

    private Renderer materialCanon;
    private Color colorOriginal;

    void Start()
    {
        materialCanon = GetComponent<Renderer>();
        colorOriginal = materialCanon.material.color;
    }

    void Update()
    {
        GameObject[] balas = GameObject.FindGameObjectsWithTag("Bala");

        // Actualizar contador
        contador.text = "Balas: " + balas.Length;

        // Comprobar si hay balas cerca
        materialCanon.material.color = colorOriginal;

        foreach (GameObject bala in balas)
        {
            if (Vector3.Distance(transform.position, bala.transform.position) < distancia)
            {
                materialCanon.material.color = Color.red;
                break;
            }
        }
    }

    public void Disparar()
    {
        // Crear y lanzar bala
        GameObject bala = Instantiate(prefabBala,
            puntoDisparo.position, puntoDisparo.rotation);

        bala.GetComponent<Rigidbody>().AddForce(
            puntoDisparo.forward * fuerza, ForceMode.Impulse);
    }

    public void EliminarBalas()
    {
        // Eliminar todas las balas
        GameObject[] balas = GameObject.FindGameObjectsWithTag("Bala");

        foreach (GameObject bala in balas)
        {
            Destroy(bala);
        }
    }

    public void DisparoAleatorio()
    {
        GameObject bala = Instantiate(prefabBala,
            puntoDisparo.position, puntoDisparo.rotation);

        // Tamaño aleatorio
        bala.transform.localScale = Vector3.one * Random.Range(0.2f, 0.8f);

        // Color aleatorio
        Color[] colores = {
            Color.red, Color.green, Color.blue,
            Color.yellow, Color.white
        };

        bala.GetComponent<Renderer>().material.color =
            colores[Random.Range(0, colores.Length)];

        // Fuerza aleatoria
        bala.GetComponent<Rigidbody>().AddForce(
            puntoDisparo.forward * Random.Range(10f, 25f),
            ForceMode.Impulse);
    }
}