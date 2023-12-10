using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public float minXPosition;
    public float maxXPosition;
    public float minTime;
    public float maxTime;
    public GameObject[] enemigosPrefabs;
    public GameManagerControl gameManager;


    void Start()
    {   
        float time = Random.Range(minTime, maxTime);    
        Invoke("SpawnEnemies", time);
    }

    void SpawnEnemies()
    {
        float time = Random.Range(minTime, maxTime);
        float x = Random.Range(minXPosition, maxXPosition);
        Vector2 position = new Vector2(x, 6.26f);
        int randomIndex = Random.Range(0, enemigosPrefabs.Length);
        GameObject prefabArray = enemigosPrefabs[randomIndex];
        GameObject enemy = Instantiate(prefabArray, position, transform.rotation);
        enemy.GetComponent<Enemy>().gameManager = gameManager;
        Invoke("SpawnEnemies", time);
    }
}

