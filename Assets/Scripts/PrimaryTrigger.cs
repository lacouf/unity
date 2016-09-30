using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PrimaryTrigger : MonoBehaviour {

	void OnTriggerEnter(Collider collider) {
		
		ExpectCollider ();

		print ("Primary Trigger Entered");
	}

	void ExpectCollider() {
		SecondaryTrigger secondaryTrigger = GetComponentInChildren<SecondaryTrigger> ();
		secondaryTrigger.ExpectCollider ();
	}
}
