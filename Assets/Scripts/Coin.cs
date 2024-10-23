// File: Assets/Scripts/Coin.cs
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int coinValue = 1;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            ScoreManager.instance.AddScore(coinValue);
            Debug.Log("Coin collected");
            Destroy(gameObject);
        }
    }
}