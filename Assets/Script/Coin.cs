using UnityEngine;

public class Coin : MonoBehaviour
{
    public float Speed = 6;
    void Start()
    {
        Invoke("Speed1", 20f);
        Invoke("Speed2", 30f);
        Invoke("Speed3", 40f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Speed * Time.deltaTime); //recordar time.deltatime es para que vaya siempre fluido en tiempo
    }

    private void Speed1()
    {
        Speed = 5;
    }
    private void Speed2()
    {
        Speed = 3;
    }
    private void Speed3()
    {
        Speed = 1;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Destroyer"))
        {
            Destroy(gameObject);
        }
    }
}


