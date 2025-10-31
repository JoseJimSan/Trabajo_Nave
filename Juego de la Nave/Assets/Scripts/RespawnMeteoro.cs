using UnityEngine;

public class RespawnMeteoro : MonoBehaviour
{

    public float tiempoEntreSpawn;

    public GameObject prefabMeteorito;

    public BoxCollider2D ZonaMeteoros;

    void Start()
    {
        InvokeRepeating("Meteorito", 1, tiempoEntreSpawn);
    }

    private void Meteorito()
    {
        GameObject nuevoMeteorito = Instantiate(prefabMeteorito);
      
    }


        //Dándole una velocidad a las instancias, pero no me sirve para acelerar... Lo dejo aquí como referencia. No entiendo esto???
        
        /*Rigidbody2D rb = prefabMeteorito.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.gravityScale = 0;
            rb.linearVelocity = Vector2.right * velocidadActual;
        }

        velocidadActual += aumentoVelocidad;*/
    

}
