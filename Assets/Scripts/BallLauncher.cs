using UnityEngine;
using System.Collections;

public class BallLauncher : MonoBehaviour {

	public GameObject ballPrefab;
	public ScoreKeeper scoreKeeper;

	public float ballSpeed = 45.0f;

	// Use this for initialization
	void Start () {
		scoreKeeper = FindObjectOfType<ScoreKeeper>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire1")) {
			GameObject instance = Instantiate(ballPrefab);
			// Sets the new ball @ the location this script is attached to. (Camera)
			instance.transform.position = transform.position;  
			Rigidbody rb = instance.GetComponent<Rigidbody> ();
			//rb.velocity = new Vector3 (0, 0, ballSpeed);
			Camera camera = GetComponentInChildren<Camera> ();
			rb.velocity = camera.transform.rotation * Vector3.forward * ballSpeed;
			if (scoreKeeper != null) {
				scoreKeeper.IncrementShoot ();
			}
		} 
	
	}
}
