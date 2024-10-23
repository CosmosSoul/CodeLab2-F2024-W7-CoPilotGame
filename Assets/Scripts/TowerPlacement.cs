// File: Assets/Scripts/TowerPlacement.cs
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerPlacement : MonoBehaviour
{
    public GameObject towerPrefab;
    public LayerMask placementLayerMask;
    public GameObject player; // Reference to the player GameObject
    public int towerCost = 3; // Cost to place a tower

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlaceTower();
        }
    }

    void PlaceTower()
    {
        if (ScoreManager.instance.GetScore() >= towerCost)
        {
            Vector3 playerPosition = player.transform.position;
            Instantiate(towerPrefab, playerPosition, Quaternion.identity);
            ScoreManager.instance.AddScore(-towerCost); // Deduct points
            Debug.Log("Tower placed at: " + playerPosition);
        }
        else
        {
            Debug.Log("Not enough points to place a tower.");
        }
    }
}