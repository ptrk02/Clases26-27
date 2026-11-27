using UnityEngine;

public class Canyon : MonoBehaviour
{
    public Transform cruceta;
    public Transform salidaBala;
    public GameObject prefabBala;
    public float velocidadBala = 30f;

    void LateUpdate()
    {
        // El cañon siempre apunta a la cruceta.
        transform.LookAt(cruceta);
    }

    public void Disparar()
    {
        transform.LookAt(cruceta);

        // Calculamos la direccion desde la salida hasta la cruceta.
        Vector3 direccion = (cruceta.position - salidaBala.position).normalized;
        GameObject bala = Instantiate(prefabBala, salidaBala.position, Quaternion.LookRotation(direccion));

        Rigidbody rb = bala.GetComponent<Rigidbody>();
        rb.useGravity = false;
        rb.AddForce(direccion * velocidadBala, ForceMode.VelocityChange);

        // Borramos la bala si no alcanza ninguna diana.
        Destroy(bala, 10f);
    }
}
