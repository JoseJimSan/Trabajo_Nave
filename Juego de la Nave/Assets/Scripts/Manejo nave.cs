using UnityEngine;

public class Manejonave : MonoBehaviour
{
    public float velocidad = 5f;
    public Rigidbody2D rb_nave;
    float movimiento;
    Vector2 Posicion_inicial;
    public Transform balaPrefab;
    // Update is called once per frame



    public void Start()
    {
        Posicion_inicial = transform.position;

    }
    // Update is called once per frame
    private void Update()
    {
        
        movimiento = Input.GetAxisRaw("Vertical");
        rb_nave.linearVelocity = new Vector2(rb_nave.linearVelocityX, velocidad * movimiento);

        //transform.position *= new Vector3(0, movimiento * velocidad * Time.deltaTime, 0);
        {
            if (Input.GetKeyDown(KeyCode.P))
            {
                Instantiate(balaPrefab,this.transform.position,Quaternion.identity);
            }

        }
    }

    public void Reset()
    {
        transform.position = Posicion_inicial;
        rb_nave.linearVelocity = Vector2.zero;
    }
}
    


