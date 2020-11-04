using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class itemSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject blockPrefab;
    float timeBetweenWaves = 1f;
    private float timeToSpawn = 2f;

    List<int> spawnedPoints = new List<int>();


    System.Random r = new System.Random();

    //Instantiate(blockPrefab, spawnPoints[index].position, Quaternion.identity);


    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            SpawnBlocks();

        }

        
    }
    void SpawnBlocks()
    {
        Debug.Log(spawnedPoints.ToString());

        //int randomIndex = Random.Range(0, spawnPoints.Length);

        for (int i = 0; i <= 2; i++)
        {
            int index = r.Next(0, spawnPoints.Length);
            spawnedPoints.Add(index);

            
            if (spawnedPoints.Contains(index) == true)
            {
                i = i + 1;
            }

        }
    }
}