using UnityEngine;

public class FruitSpawnerScript : MonoBehaviour
{
    public GameObject[] fruits;
    public float sabitY = 14f;
    public float sabitZ = 2f;
    void Start()
    {
        
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int randomFruit = Random.Range(0, fruits.Length);
            Vector3 spawnPos = new Vector3(Random.Range(-7.5f, 7.5f), sabitY, sabitZ);
            
            Instantiate(fruits[randomFruit], spawnPos, Quaternion.identity);
        }
    }
}
