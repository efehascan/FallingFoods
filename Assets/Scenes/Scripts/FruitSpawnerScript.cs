using UnityEngine;
using System.Collections;

public class FruitSpawnerScript : MonoBehaviour
{
    public GameObject[] fruits;
    public float sabitY = 14f;
    public float sabitZ = 2f;
    void Start()
    {
        StartCoroutine(SpawnFruit());
    }
    
    void Update()
    {
        
    }

    IEnumerator SpawnFruit()
    {
        while (true)
        {
            int randomFruit = Random.Range(0, fruits.Length);
            Vector3 spawnPos = new Vector3(Random.Range(-7f, 7f), sabitY, sabitZ);
            
            Instantiate(fruits[randomFruit], spawnPos, Quaternion.identity);
            
            yield return new WaitForSeconds(0.2f);
        }
    }
}
