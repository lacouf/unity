using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SecondaryTrigger : MonoBehaviour {

	static int GAMEOVERSCENE = 2;

	bool expectCollider;

	ScoreKeeper scoreKeeper;

	void OnTriggerEnter(Collider collider) {

		if (scoreKeeper == null) {
			scoreKeeper = FindObjectOfType<ScoreKeeper> ();
		}
			
		if (expectCollider) {
			int score = scoreKeeper.IncrementScore (1);
			print ("Score: " + score + " with total shoot of : " + scoreKeeper.shoot);
			expectCollider = false;
		}

		if (scoreKeeper.isGameOver ()) {
			SceneManager.LoadScene (GAMEOVERSCENE);
		}
			
	}

	public void ExpectCollider() {
		expectCollider = true;
	}
}
