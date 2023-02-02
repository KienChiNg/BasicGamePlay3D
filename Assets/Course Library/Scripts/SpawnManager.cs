using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] animalPrefabs;
    [SerializeField] private GameObject[] animalPrefabs2;
    [SerializeField] private float spawnPosX = 20.0f;
    [SerializeField] private float spawnPosZ = 30.0f;
    private float startDelay = 2.0f;
    private float spawnInterval = 1f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
    }
    void SpawnRandomAnimal()
    {
        int posSpawn = Random.Range(0, 2);
        if (posSpawn == 0)
            SpawnRandomHorizontal();
        else
            SpawnRandomTop();
    }
    void SpawnRandomTop()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnPosX, spawnPosX), 0, spawnPosZ);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[0].transform.rotation);
    }
    void SpawnRandomHorizontal()
    {
        int animalIndex = Random.Range(0, animalPrefabs2.Length);
        Vector3 spawnPos = new Vector3(-spawnPosX, 0, Random.Range(-spawnPosZ, spawnPosZ));
        int posSpawn = Random.Range(0, 2);
        if (posSpawn == 0)
        {
            Instantiate(animalPrefabs2[animalIndex], spawnPos, animalPrefabs2[0].transform.rotation);
        }
        else
        {
            Instantiate(animalPrefabs2[animalIndex], -spawnPos, Quaternion.Euler(new Vector3(0, -90, 0)));
        }

    }
}
