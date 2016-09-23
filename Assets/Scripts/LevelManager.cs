using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.Assertions;

public class LevelManager : MonoBehaviour {

	//static int GAMESCENE = 1;
	//static int GAMEOVERSCENE = 2;
	static string SCORETEXT="ScoreText";
	static string SHOTSTEXT="ShotsText";

	public float timeTillNextLevel = 0.0f;

	ScoreCanevas scoreCanevas;
	ScoreKeeper scoreKeeper;
	UnityEngine.UI.Text scoreText;
	UnityEngine.UI.Text shotsText;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
		if (timeTillNextLevel > 0.0f) {
			timeTillNextLevel -= Time.deltaTime;
			print ("Time left : " + timeTillNextLevel);
			if (timeTillNextLevel <= 0.0f) {
				GoToNextLevel ();
			}
		}

		if (scoreCanevas == null) {
			scoreCanevas = (ScoreCanevas) FindObjectOfType(typeof(ScoreCanevas));
			if (scoreCanevas != null) {
				//scoreCanevas.GetComponentInChildren<UnityEngine.UI.Text> ();
				foreach (Transform child in scoreCanevas.transform) {
					if (child.gameObject.name.Equals (SCORETEXT)) {
						scoreText = child.gameObject.GetComponent<UnityEngine.UI.Text> ();
						scoreText.text = "1000";
					}
					if (child.gameObject.name.Equals (SHOTSTEXT)) {
						shotsText = child.gameObject.GetComponent<UnityEngine.UI.Text> ();
						shotsText.text = "2000";
					}
				}
			}
		}
		if (scoreKeeper == null) {
			scoreKeeper = (ScoreKeeper) FindObjectOfType(typeof(ScoreKeeper));
		}
		if (scoreKeeper != null) {
			scoreText.text = scoreKeeper.score.ToString ();
			shotsText.text = scoreKeeper.shoot.ToString ();
		}
	}

	public void GoToNextLevel() {
		int currentScene = SceneManager.GetActiveScene ().buildIndex;
		SceneManager.LoadScene (currentScene + 1);
	}

	public void GoToPreviousLevel() {
		int currentScene = SceneManager.GetActiveScene ().buildIndex;
		SceneManager.LoadScene (currentScene - 1);
	}
}
