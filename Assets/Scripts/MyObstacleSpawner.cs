using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyObstacleSpawner : MonoBehaviour
{

	[SerializeField] GameObject[] ghosts;
	public float spawnDelay;
	public float spawnRate;

	// Use this for initialization
	
	
	
	void Start()
	{
		InvokeRepeating("Spawn", spawnDelay, spawnRate);
	}


	void Spawn()
	{
		GameObject clone = Instantiate(ghosts[Random.Range(0,2)], transform.position, Quaternion.identity);
		//Destroy(clone, 2f);
	}
}