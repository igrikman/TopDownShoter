using System.Collections;
using System.Collections.Generic;
using UnityEngine;



////�����:
//1. ����������� �� ����� ����������; +
//2. ����������� �� ������� ������;   +
//3. �������� �� ��� �� �����;
//4. ������� �����;
//5. ������;
//6. ���������� �������� ������ ���������� � ���������� ����������� �� ������ ���������� ;
//7. ����������� � ��������;+
//8. ������� ������� � ����; 

public class Sc_GameController : MonoBehaviour
{
    [Header("Parametrs")]
    [SerializeField] private Transform[] spawnPoints;
    [SerializeField] private Sc_Player playerPrefab;
    [SerializeField] private Sc_Enemy enemyPrefab;
    [SerializeField] private float spawnDelay;
    
    private int listCount = 10;
    private List<Sc_Enemy> enemyList;
    private void Start()
    {
        Sc_EvetManager.OnEnemyKilled += RemoveOnList;
        enemyList = new List<Sc_Enemy>();
        InvokeRepeating("Spawn", spawnDelay, spawnDelay);
    }
    private void Update()
    {

    }
    private void Spawn()
    {
        if (enemyList.Count <= listCount)
        {
            int spawnPointIndex = Random.Range(0, spawnPoints.Length);
            var enemy = Instantiate(enemyPrefab, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
            enemy.SetPlayer(playerPrefab.transform);
            enemyList.Add(enemy);
            Debug.Log("Add.List");
        }
        else
        {
            Debug.Log("enemyList.Count >= listCount");
        }
    }
    private void RemoveOnList()
    {
        foreach (var enemy in enemyList)
        {
            if (enemy.isDead)
            {
                Debug.Log("����� � if isDead");
                RemoveEnemy(enemy);
                break;
            }
        }
    }
    private void RemoveEnemy(Sc_Enemy enemy)
    {
        enemyList.Remove(enemy);
        Debug.Log("Destroy.enemy");
        Destroy(enemy.gameObject);
    }
}

