using NUnit.Framework;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.WSA;

public class Meteorito : MonoBehaviour
{
    public float velocidad = 2f;

    public float aceleracion = 0.5f;

    public Rigidbody2D rb_meteorito;

    public Object GameObject;

    private void Start()
    {
        PosicionRandom();
       
    }

    void PosicionRandom()
    {

        float posicionYRandom = Random.Range(-5, 5);

        transform.position = new Vector3(-12, Mathf.Floor(posicionYRandom), 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Nave"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        }
        else if (collision.CompareTag("ZonaDestruccion"))
        {
            PosicionRandom();
            velocidad = 20f;
        }
        else if (collision.CompareTag("bala"))
        {
            Destroy(this.GameObject);
            Destroy(collision.gameObject);
        }
    }
}
