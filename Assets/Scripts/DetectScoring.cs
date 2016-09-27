using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class DetectScoring : MonoBehaviour {

	static int GAMEOVERSCENE = 2;

	public ScoreKeeper scoreKeeper;
	public ScoreCanevas scoreCanevas;

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

		if (scoreKeeper.isGameOver ()) {
			SceneManager.LoadScene (GAMEOVERSCENE);
		}

	}
}
