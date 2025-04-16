using TMPro;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float distance = 3f; // en la que se mueva
    private int actual = 1; // 1 centro seria 2 derecha 0 izquierda
    public float cambioSpeed = 5f; // velocidad hacia adelante
    public float Speed = 1f;
    private float posicionActual;
    void Start()
    {
        posicionActual = actual * distance;
        transform.position = new Vector3(transform.position.x, transform.position.y, posicionActual);
    }
    // Update is called once per frame
    void Update()
    {

        //transform.Translate(Vector3.left * Speed * Time.deltaTime); //se mueve para adelante
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (actual > 0)
            {
                actual--;
            }
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            if (actual < 2)
            {
                actual++;

            }
        }
        posicionActual = actual * distance;
        Vector3 posicion = new Vector3(transform.position.x, transform.position.y, posicionActual); //agarra la distancia del nuevo vector
        transform.position = Vector3.Lerp(transform.position, posicion, Time.deltaTime * cambioSpeed); //lo mueve al vector
    }
} 

