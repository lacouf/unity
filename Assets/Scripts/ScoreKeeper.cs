using UnityEngine;
using System.Collections;

public class ScoreKeeper : MonoBehaviour {

	public int score = 0;
	public int shoot = 0;

	// Use this for initialization
	void Start () {
	
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
}
