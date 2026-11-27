using UnityEngine;

public class Diana : MonoBehaviour
{
    [HideInInspector] public GameManager gameManager;
    bool alcanzada = false;

    void OnCollisionEnter(Collision collision)
    {
        // Comprobamos que la diana ha chocado con una bala.
        if (alcanzada || !collision.gameObject.CompareTag("Bala")) return;
        alcanzada = true;

        // Borramos la bala y la diana y generamos otra.
        Destroy(collision.gameObject);
        Destroy(gameObject);
        gameManager.GenerarDiana();
    }
}
