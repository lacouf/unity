using UnityEngine;
using System.Collections;

public class BallCollider : MonoBehaviour {

	void OnCollisionEnter(Collision collision) {
		AudioSource source = GetComponent<AudioSource> ();
		source.Play ();
	}

}
