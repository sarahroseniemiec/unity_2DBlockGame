using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
	public GameObject fallingBlockPrefab;
	public float secondsBetweenSpawns = 1;
	float nextSpawnTime;

	Vector2 screenHalfSizeInWorldUnits;
	// Use this for initialization
	void Start () {
		screenHalfSizeInWorldUnits = new Vector2 (Camera.main.aspect * Camera.main.orthographicSize, Camera.main.orthographicSize);
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > nextSpawnTime) {
			nextSpawnTime = Time.time + secondsBetweenSpawns;
			Vector2 spawnPosition = new Vector2 (Random.Range (-screenHalfSizeInWorldUnits.x, screenHalfSizeInWorldUnits.x), screenHalfSizeInWorldUnits.y + 0.5f);
			Instantiate (fallingBlockPrefab, spawnPosition, Quaternion.identity);
		}

	}
}
