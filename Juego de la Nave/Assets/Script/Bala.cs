using UnityEngine;
using UnityEngine.WSA;

public class bala : MonoBehaviour
{
    public float velocidad = 7f;
    public Rigidbody2D Rb_bala;
    float movimiento;
    Vector2 Posicion_inicial;
    
    public void Start()
    {
        Posicion_inicial = transform.position;
    }
    
    public void launch()
    {
      

        float VelocidadX = velocidad;

        Rb_bala.linearVelocity = new Vector2(VelocidadX, 0) * velocidad;
    }

}
