using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	static int GAMESCENE = 1;
	static int GAMEOVERSCENE = 2;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space)) {
			SceneManager.LoadScene(GAMESCENE);
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
