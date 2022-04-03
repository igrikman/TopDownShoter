using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sc_Spawner : MonoBehaviour
{
    [SerializeField] private List<Transform> spawnPoints = new List<Transform>();
    [SerializeField] private float spawnDelay;
    [SerializeField] private List<GameObject> enemyPrefabs = new List<GameObject>();
    private int amountEnemies = 5;
    private void Start()
    { 
            StartCoroutine(spawn());  
    }
    private void SpawnEnemy()
    {
        for (int i = 0; i < amountEnemies; i++)
        {
            Transform spawnPoint = GetRandomSpawnPoint();
            GameObject enemy = SpawnEnemy(spawnPoint);
        }
    }
    private Transform GetRandomSpawnPoint()
    {
        return spawnPoints[Random.Range(0, spawnPoints.Count)];
    }

    private GameObject SpawnEnemy(Transform spawnPoint)
    {
        var prefab = enemyPrefabs[Random.Range(0, enemyPrefabs.Count)];
        return Instantiate(prefab, spawnPoint.position, spawnPoint.rotation);
    }

    IEnumerator spawn ()
    {
        yield return new WaitForSeconds(spawnDelay);
        SpawnEnemy();
    }    




}
