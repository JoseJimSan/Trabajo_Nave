using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.WSA;

public class bala : MonoBehaviour
{
    public float velocidad = 7f;
    public Rigidbody2D Rb_bala;
    float movimiento;
    Vector2 Posicion_inicial;
    public Object GameObject;

    public void Start()
    {
        Posicion_inicial = transform.position;
    }
    
    public void launch()
    {
      

        float VelocidadX = velocidad;

        Rb_bala.linearVelocity = new Vector2(VelocidadX, 0) * velocidad;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("ZonaDestruccion"))
        {
            Destroy(this.GameObject);
        }
        else if (collision.CompareTag("Meteorito"))
        {
            Destroy(this.GameObject);
            Destroy(collision.gameObject);
        }
    }
}
