using UnityEngine;
using System.Collections;

public class BasicTargetMover : MonoBehaviour {

	public float spinSpeed = 180.0f;
	public float motionMagnitude = 0.1f;

	public bool doSpin = true;
	public bool doMotion = true;

	// Update is called once per frame
	void Update () {

		if (doSpin) {
			// rotate around the up axis of the gameObject
			gameObject.transform.Rotate (Vector3.up * spinSpeed * Time.deltaTime);
		}
		
		if (doMotion) {
			// move up and down over time
			// Time.timeSinceLevelLoad
			// The time this frame has started (Read Only). This is the time in seconds since the last level has been loaded.
			gameObject.transform.Translate(Vector3.up * Mathf.Cos(Time.timeSinceLevelLoad) * motionMagnitude);

		}
	}
}
