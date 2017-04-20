﻿using UnityEngine;
using System.Collections;

public class WaveSpawner : MonoBehaviour
{
    public Transform enemyPrefab;
    public float timeBetweenWaves = 5f;
    public Transform spawnPoint;


    private float countdown = 2f;
    private int waveCount = 0;


    void Update()
    {
        if (countdown <= 0f)
        {
			StartCoroutine(SpawnWave());
            countdown = timeBetweenWaves;
        }

        countdown -= Time.deltaTime;
    }

    IEnumerator SpawnWave()
    {
        waveCount++;

        for (int i = 0; i < waveCount; i++)
        {
            SpawnEnemy();
            // Wait for 0.5 seconds before spawn new enemy
            yield return new WaitForSeconds(0.5f);
        }
    }

    private void SpawnEnemy()
    {
        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}
