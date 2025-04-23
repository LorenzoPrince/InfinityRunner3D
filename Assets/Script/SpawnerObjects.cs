using UnityEngine;

public class SpawnerObjects : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] GameObject[] blocks;
    public Transform spawnPoint;


    void Start()
    {
        SpawnBlock();
        InvokeRepeating("SpawnBlock", 0, 6f);
        Invoke("ChangeSpawnBlock2", 20f);
        Invoke("SpeedUpSpawnBlock2", 30f);
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
        Debug.Log("Cambiando a SpawnBlock2");
        CancelInvoke("SpawnBlock");
        InvokeRepeating("SpawnBlock2", 0f, 5f);
    }
    void SpeedUpSpawnBlock2()
    {
        Debug.Log("⚡ Acelerando SpawnBlock2 a cada 3 segundos");
        CancelInvoke("SpawnBlock2"); // Cancela solo este si estaba corriendo
        InvokeRepeating("SpawnBlock2", 0f, 3f);
    }
}

