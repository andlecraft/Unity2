using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] enemyObjs;
    public Transform[] spawnPoint;

    public float maxSpawnDelay;
    public float curSpawnDelay;

    void Update()
    {
        curSpawnDelay += Time.deltaTime;
        if (curSpawnDelay > maxSpawnDelay )
        {
            SpawnEnemy();
            maxSpawnDelay = Random.Range( 0.5f,3f);
            curSpawnDelay = 0;
        }
    }

    void SpawnEnemy()
    {
        int ranEnemy = Random.Range(0, 3);
        int ranPoint = Random.Range(0, 3);
        Instantiate(enemyObjs[ranEnemy],
            spawnPoint[ranPoint].position,
            spawnPoint[ranPoint].rotation);
    }
}
