using System.Collections;
using System.Collections.Generic;
using UnityEngine;

////Нужно:
//1. Ограничение на спавн противника;
//2. Ограничение по времени спавна;
//3. Проверка на жив ли игрок;
//4. Система очков;
//5. Бонусы;
//6. Увеличение скорости;
//7. Навести порядок в коде;

public class Sc_Spawner : MonoBehaviour
{
    [Header("Parametrs")]
    [SerializeField] private Transform[] spawnPoints;
    [SerializeField] private GameObject enemyPrefabs;
    [SerializeField] private Sc_Player player;
    [SerializeField] private Sc_Enemy enemyPrefab;
    [SerializeField] private float spawnDelay;
    private void Start()
    {
        InvokeRepeating("Spawn", spawnDelay, spawnDelay);
    }
    public void Spawn()
    {

        int spawnPointIndex = Random.Range(0, spawnPoints.Length);
        var enemy = Instantiate(enemyPrefabs, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
        enemyPrefab.SetPlayer(player.transform);
    }




}

