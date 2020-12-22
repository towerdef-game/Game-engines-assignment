using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wavespawner : MonoBehaviour
{
    public static int Enemiesalive = 0;
    public float eny;
    // public Transform enemyPrefab;
    public wavedetails[] waves;
    public float timeBetweenWave = 5f;
    public float countdown = 5f;
    private int waveIndex = 0;
    public Transform EnemySpawnPoint;
    public Transform EnemySpawnPoint2;

    public float WaitTime = 0.5f;
  
    public GameManager gameManager;

    public void Update()
    {
        eny = Enemiesalive;
        if (Enemiesalive > 0)
        {
            return;
        }
        if (countdown < 0)
        {
            StartCoroutine(SpawnWave());
            countdown = timeBetweenWave;
            return;
        }

        if (waveIndex == waves.Length && Enemiesalive <= 0)
        {
            gameManager.WinLevel();
        }

        countdown -= Time.deltaTime;
    }

    IEnumerator SpawnWave()
    {

        GameManager.Rounds++;

        wavedetails wave = waves[waveIndex];

        Enemiesalive = wave.amount;

        for (int i = 0; i < wave.amount; i++)
        {
            EnemySpawn(wave.enemy);
            EnemySpawn2(wave.enemy);
            yield return new WaitForSeconds(1f / wave.spawnrate);

        }
        waveIndex++;


    }

    private void EnemySpawn(GameObject enemy)
    {
        Instantiate(enemy, EnemySpawnPoint.position, EnemySpawnPoint.rotation);

    }
    private void EnemySpawn2(GameObject enemy)
    {
        Instantiate(enemy, EnemySpawnPoint2.position, EnemySpawnPoint2.rotation);
        Enemiesalive += 1;
    }



}

