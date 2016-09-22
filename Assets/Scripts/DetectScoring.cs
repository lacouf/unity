using UnityEngine;
using System.Collections;

public class DetectScoring : MonoBehaviour {

	public ScoreKeeper scoreKeeper;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision collision) {
		if (scoreKeeper == null) {
			scoreKeeper = FindObjectOfType<ScoreKeeper> ();
		}
		print("Score: " + scoreKeeper.IncrementScore(1) + " with total shoot of : " + scoreKeeper.shoot);

	}
}
