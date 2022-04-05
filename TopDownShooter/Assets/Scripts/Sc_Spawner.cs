using System.Collections;
using System.Collections.Generic;
using UnityEngine;

////�����:
//1. ����������� �� ����� ����������;
//2. ����������� �� ������� ������;
//3. �������� �� ��� �� �����;
//4. ������� �����;
//5. ������;
//6. ���������� ��������;
//7. ������� ������� � ����;

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

