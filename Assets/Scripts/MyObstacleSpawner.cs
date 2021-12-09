using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyObstacleSpawner : MonoBehaviour
{

	[SerializeField] GameObject[] ghosts; // Array for Ghosts
	public float spawnDelay;
	public float spawnRate;
	
	void Start()
	{
		InvokeRepeating("Spawn", spawnDelay, spawnRate);
	}
	void Spawn()
	{
		// Spawn Ghosts from array random
		GameObject clone = Instantiate(ghosts[Random.Range(0,2)], transform.position, Quaternion.identity); 
	}
}