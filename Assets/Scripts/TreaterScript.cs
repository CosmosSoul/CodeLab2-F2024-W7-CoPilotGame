// File: Assets/Scripts/Treater.cs
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreaterScript : MonoBehaviour
{
    public float speed = 2f;

    void Update()
    {
        GameObject nearestCoin = FindNearestCoin();
        if (nearestCoin != null)
        {
            MoveTowards(nearestCoin);
        }
    }

    GameObject FindNearestCoin()
    {
        GameObject[] coins = GameObject.FindGameObjectsWithTag("Coin");
        GameObject nearestCoin = null;
        float minDistance = Mathf.Infinity;
        Vector3 currentPosition = transform.position;

        foreach (GameObject coin in coins)
        {
            float distance = Vector3.Distance(currentPosition, coin.transform.position);
            if (distance < minDistance)
            {
                nearestCoin = coin;
                minDistance = distance;
            }
        }

        return nearestCoin;
    }

    void MoveTowards(GameObject target)
    {
        Vector3 targetPosition = target.transform.position;
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
    }
}