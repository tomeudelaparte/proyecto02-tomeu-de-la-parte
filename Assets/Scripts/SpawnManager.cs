using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    private Vector3 spawnPosition;

    private float xRange = 15f;
    private float spawnZ = 25f;

    private float startTime = 1f;
    private float repeatRate = 1f;

    private int randomIndex;
    private float randomX;

    void Start()
    {
        InvokeRepeating("SpawnEnemy", startTime, repeatRate);
    }

    public Vector3 RandomPosition()
    {
        randomX = Random.Range(-xRange, xRange);

        return new Vector3(randomX, 0, spawnZ);
    }

    public void SpawnEnemy()
    {
        randomIndex = Random.Range(0, enemyPrefabs.Length);

        spawnPosition = RandomPosition();

        Instantiate(enemyPrefabs[randomIndex], spawnPosition, enemyPrefabs[randomIndex].transform.rotation);
    }
}
