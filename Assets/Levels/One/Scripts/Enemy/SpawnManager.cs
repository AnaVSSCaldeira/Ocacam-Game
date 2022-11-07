using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpawnManager : MonoBehaviour
{
    public Transform[] spawnPoints;

    public GameObject enemy;

    void Start()
    {
        InvokeRepeating("Spawner", 0.5f, 2f);           
    }

    void Spawner ()
    {
        int index = Random.Range(0, spawnPoints.Length);
        Instantiate(enemy, spawnPoints[index].position, Quaternion.identity);
    }
}
