using UnityEngine;

public class moveObjectScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float Speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Speed * Time.deltaTime); //recordar time.deltatime es para que vaya siempre fluido en tiempo
    }
}
