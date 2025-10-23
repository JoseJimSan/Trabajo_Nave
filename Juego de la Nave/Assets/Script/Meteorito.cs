using UnityEngine;
using UnityEngine.WSA;

public class Meteorito : MonoBehaviour
{
    public float velocidad = 2f;

    public float aceleracion = 1f;

    public Rigidbody2D rb_meteorito;

    public BoxCollider2D ZonaMeteoros;


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
        velocidad += aceleracion * Time.deltaTime;

        rb_meteorito.linearVelocity = new Vector2(VelocidadX, 0) * velocidad;
    }
}
