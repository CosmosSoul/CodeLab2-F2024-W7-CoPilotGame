// File: Assets/Scripts/CoinSpawner.cs
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coinPrefab;
    public float spawnAreaWidth = 10f;
    public float spawnAreaHeight = 10f;
    public float spawnInterval = 3f; // Interval in seconds

    void Start()
    {
        InvokeRepeating("SpawnCoin", 3f, spawnInterval);
    }

    void SpawnCoin()
    {
        Vector3 randomPosition = new Vector3(
            Random.Range(-spawnAreaWidth / 2, spawnAreaWidth / 2),
            Random.Range(-spawnAreaHeight / 2, spawnAreaHeight / 2),
            0
        );
        Instantiate(coinPrefab, randomPosition, Quaternion.identity);
    }
}