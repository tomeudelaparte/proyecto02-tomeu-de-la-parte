using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    public Vector3 spawnPosition = new Vector3(0, 0, 25);

    private float xRange = 15f;
    private int randomIndex;

    void Start()
    {
        InvokeRepeating("SpawnEnemy", 1, 1f);
    }

    public Vector3 RandomPosition()
    {
        float randomX = Random.Range(-xRange, xRange);

        return new Vector3(randomX, 0, 25);
    }


    public void SpawnEnemy()
    {
        randomIndex = Random.Range(0, enemyPrefabs.Length);

        spawnPosition = RandomPosition();

        Instantiate(enemyPrefabs[randomIndex], spawnPosition, enemyPrefabs[randomIndex].transform.rotation);
    }
}
