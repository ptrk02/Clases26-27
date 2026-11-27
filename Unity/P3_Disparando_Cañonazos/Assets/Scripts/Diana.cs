using UnityEngine;

public class Diana : MonoBehaviour
{
    private int impactos = 0;
    public float velocidadRotacion = 30f;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bala"))
        {
            impactos++;

            // Primer impacto
            if (impactos == 1)
            {
                GetComponent<Renderer>().material.color = Color.red;
            }

            // Tercer impacto
            if (impactos == 3)
            {
                Destroy(gameObject);
            }
        }
    }

    void Update()
    {
        // Segundo impacto
        if (impactos == 2)
        {
            transform.Rotate(0, velocidadRotacion * Time.deltaTime, 0);
        }
    }
}