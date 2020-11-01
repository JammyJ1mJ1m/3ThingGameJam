using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SpawnAtRandomLocation : MonoBehaviour
{
    public GameObject[] objectsToSpawn; // reference to the spawn key
    public Transform[] spawnPoints; // array of spawn points
    public List<int> spawnedObjects; // list of spawned points
    public int spawnCount; 
    private int spawnIndex;

    public GameObject blockPrefab;

    void Start()
    {
        // Use this for loop to not hardcode the spawn count

        for (int i = 0; i < spawnCount; i++)
        {

            spawnIndex = Random.Range(0, spawnPoints.Length);
            // Instantiate object
            Instantiate(blockPrefab, spawnPoints[spawnIndex].position, Quaternion.identity);

            if (spawnedObjects.Contains(spawnIndex))
            {
                spawnIndex = Random.Range(0, spawnPoints.Length);

                Instantiate(blockPrefab, spawnPoints[spawnIndex].position, Quaternion.identity);
                
                spawnedObjects.Add(spawnIndex);
                
                Debug.LogWarning("if" + spawnIndex);

            }
            else
            {
                spawnedObjects.Add(spawnIndex);
                
                Debug.LogWarning("else" + spawnIndex);

                foreach (int x in spawnedObjects)
                {
                    Debug.Log(x.ToString());
                }


            }
        }
    }
    
}