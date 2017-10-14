using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
	public GameObject enemyPrefab;
	public float spawnTimer = 5.0f;

	void Start()
	{
		StartSpawning();
	}


	void SpawnEnemy()
	{
		Instantiate(enemyPrefab, transform.position, Quaternion.identity);
	}

	void StartSpawning()
	{
		InvokeRepeating("SpawnEnemy", spawnTimer, spawnTimer);
	}

	void StopSpawning()
	{
		CancelInvoke();
	}
}
