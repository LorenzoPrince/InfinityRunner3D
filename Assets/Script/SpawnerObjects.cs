using UnityEngine;

public class SpawnerObjects : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] GameObject[] blocks;
    public Transform spawnPoint;


    private string metodoActual;
    private float interval = 6f;


    void Start()
    {
        metodoActual = "SpawnBlock";
        InvokeRepeating("SpawnBlock", 0, interval);
        Invoke("ChangeSpawnBlock2", 20f);
        Invoke("SpeedUpSpawnBlock2", 30f);
        Invoke("SpeedUpSpawnBlock3", 50f);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void SpawnBlock()
    {
        int mitad = blocks.Length / 2;
        int randomIndex = Random.Range(0, mitad); //elije un numero entre 0 y el tamaño de la array
        GameObject block = Instantiate(blocks[randomIndex], transform.position, Quaternion.identity);
        block.transform.SetParent(transform); // hace que se muevan los hijos tambien.
    }
    public void SpawnBlock2()
    {
        int mitad = blocks.Length / 2;
        int randomIndex = Random.Range(mitad, blocks.Length); //elije un numero entre 0 y el tamaño de la array
        GameObject block = Instantiate(blocks[randomIndex], transform.position, Quaternion.identity);
        block.transform.SetParent(transform); // hace que se muevan los hijos tambien.
    }
    void ChangeSpawnBlock2()

    {
        if (metodoActual != "SpawnBlock2")
        {
            Debug.Log("Cambiando a SpawnBlock2 HEAVY");
            CancelInvoke(metodoActual); // Cancela el método que estaba antes
            metodoActual = "SpawnBlock2";
            interval = 5f;
            InvokeRepeating(metodoActual, 0f, interval);
        }
    }
    void SpeedUpSpawnBlock2()
    {
        if (metodoActual == "SpawnBlock2" && interval != 3f)
        {
            Debug.Log("Acelerando SpawnBlock2 a cada 3 segundos AAAAAAAAAVERYHEAVY");
            CancelInvoke(metodoActual);
            interval = 3f;
            InvokeRepeating(metodoActual, 0f, interval);
        }

    }
    void SpeedUpSpawnBlock3()
    {
        if (metodoActual == "SpawnBlock2" && interval != 3f)
        {
            Debug.Log("Acelerando SpawnBlock2 a cada 3 segundos AAAAAAAAAVERYHEAVY");
            CancelInvoke(metodoActual);  
            interval = 1f; 
            InvokeRepeating(metodoActual, 0f, interval);  
        }

    }
}

