﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingBlocks : MonoBehaviour {
	public Vector2 speedMinMax;
	float speed;

	float visibleHeightThreshold;
	// Use this for initialization
	void Start () {
		speed = Mathf.Lerp (speedMinMax.x, speedMinMax.y, Difficulty.GetDifficultyPercent ());
		visibleHeightThreshold = -Camera.main.orthographicSize - transform.localScale.y;
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.Translate (Vector3.down * speed * Time.deltaTime);
		if (transform.position.y < visibleHeightThreshold) {
			Destroy (gameObject);
		} 
	}


}

