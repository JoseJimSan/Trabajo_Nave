using NUnit.Framework;
using UnityEngine;
using UnityEngine.WSA;

public class Meteorito : MonoBehaviour
{
    public float velocidad = 2f;

    public Rigidbody2D rb_meteorito;

    public BoxCollider2D ZonaMeteoros;

    public Object GameObject;

    public float tiempoEntreSpawn;

    private void Start()
    {
        PosicionRandom();
        Launch();
    }

    void PosicionRandom()
    {
        Bounds limites = ZonaMeteoros.bounds;

        float y = Random.Range(limites.min.y, limites.max.y);

        transform.position = new Vector3(-10, Mathf.Floor(y), 0);
    }

    void Launch()
    {
        float VelocidadX = velocidad;

        rb_meteorito.linearVelocity = new Vector2(VelocidadX, 0) * velocidad;
    }

    private void Update()
    {
        InvokeRepeating("Meteorito", 1, tiempoEntreSpawn);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Nave"))
        {
            Start();
            float VelocidadX = velocidad;
        }
        else if (collision.CompareTag("ZonaDestruccion"))
        {
            PosicionRandom();
        }
        else if (collision.CompareTag("bala"))
        {
            Destroy(this.GameObject);
            Destroy(collision.gameObject);
        }
    }
}
