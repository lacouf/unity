using UnityEngine;
using System.Collections;

public class ScoreKeeper : MonoBehaviour {

	static int GAMEOVERSCORE = 20;

	public int score = 0;
	public int shoot = 0;

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (gameObject);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public int IncrementScore(int scoreToAdd) {
		score = score + scoreToAdd;
		return score;
		//print ("New Score : " + score);
	}

	public void IncrementShoot() {
		shoot++;
	}

	public bool isGameOver() {
		return score >= GAMEOVERSCORE;
	}
}
