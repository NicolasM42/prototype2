using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;

    private float spawnPosX = -15;

    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    private Vector3 spawnPos;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("RandomSpawn", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void RandomSpawn()
    {
        // Randomly choose which animal to spawn
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        if (Random.Range(0, 2) == 0)
        {
            // Generate a new random location on the X axis to spawn the thingy
            spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
            // Spawn at location
            Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
        }
        else
        {
            // Generate a new random location on the X axis to spawn the thingy
            spawnPos = new Vector3(spawnPosX, 0, Random.Range(-5, 20));
            // Spawn at location
            GameObject animal = Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
            animal.transform.Rotate(0, -90, 0);
        }
    }
}
