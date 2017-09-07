﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {
	public GameObject gameOverScreen;
	public Text secondsSurvivedUI;
	bool gameOver;

	void Start() {
		FindObjectOfType<Player> ().OnPlayerDeath += OnGameOver;
	}
	
	// Update is called once per frame
	void Update () {
		if (gameOver) {
			if (Input.GetKeyDown(KeyCode.Space)) {
				SceneManager.LoadScene (0);
				gameOver = false;
			}
		}
		
	}

	void OnGameOver() {
		gameOverScreen.SetActive(true);
		secondsSurvivedUI.text = Mathf.RoundToInt(Time.timeSinceLevelLoad).ToString();
		gameOver = true;
	}
}
