using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Vector3 spawnPosition = new Vector3(0, 0, 25);

    private float xRange = 15f;

    void Start()
    {
        InvokeRepeating("SpawnEnemy", 2, 1.5f);
    }

    public Vector3 RandomPosition()
    {
        float randomX = Random.Range(-xRange, xRange);

        return new Vector3(randomX, 0, 25);
    }

    public void SpawnEnemy()
    {
        spawnPosition = RandomPosition();

        Instantiate(enemyPrefab, spawnPosition, enemyPrefab.transform.rotation);
    }
}
