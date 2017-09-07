using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
	public GameObject fallingBlockPrefab;
	public float secondsBetweenSpawns = 1;
	float nextSpawnTime;


	public Vector2 spawnSizeMinMax;
	public float spawnAngleMax;
	Vector2 screenHalfSizeInWorldUnits;
	// Use this for initialization
	void Start () {
		screenHalfSizeInWorldUnits = new Vector2 (Camera.main.aspect * Camera.main.orthographicSize, Camera.main.orthographicSize);
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > nextSpawnTime) {
			nextSpawnTime = Time.time + secondsBetweenSpawns;
			float spawnAngle = Random.Range (-spawnAngleMax, spawnAngleMax);
			float spawnSize = Random.Range (spawnSizeMinMax.x, spawnSizeMinMax.y);

			Vector2 spawnPosition = new Vector2 (Random.Range (-screenHalfSizeInWorldUnits.x, screenHalfSizeInWorldUnits.x), screenHalfSizeInWorldUnits.y + spawnSize);
//			Quaternion randomRotation = Quaternion.Euler (new Vector2 (Random.Range(-20, 20), Random.Range(-20, 20)));
//
			GameObject newCube = (GameObject)Instantiate (fallingBlockPrefab, spawnPosition, Quaternion.Euler (Vector3.forward * spawnAngle));

			newCube.transform.localScale = Vector2.one * spawnSize;
		}

	}


}
