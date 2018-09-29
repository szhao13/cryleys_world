using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AltCharacterController : MonoBehaviour {
	public float inputDelay = 0.1f; // small delay between pressing go.
	public float forwardVel = 12;
	public float rotateVel = 100;

	Quaternion targetRotation; // quaternions are objects that hold rotations...
	Rigidbody rBody;
	float forwardInput, turnInput;

	public Quaternion TargetRotation
	{
		get { return targetRotation; }
	}

	void Start()
	{
		targetRotation = transform.rotation;
		if (GetComponent<Rigidbody> ())
			rBody = GetComponent<Rigidbody> ();
		else
			Debug.LogError ("The character needs a rigid body.");

		forwardInput = turnInput = 0;


	}

	void GetInput()
	{
		// GetAxis returns an interpolated value from -1 to 1.
		forwardInput = Input.GetAxis ("Vertical");
		turnInput = Input.GetAxis ("Horizontal");
	}

	void Update()
	{
		GetInput ();
		Turn ();
	}

	void FixedUpdate() 
	{
		Run ();
	}

	void Run()
	{
		if (Mathf.Abs (forwardInput) > inputDelay) {
			// move
			rBody.velocity = transform.forward * forwardInput * forwardVel;
		}
		else
			// zero velocity
			rBody.velocity = Vector3.zero;
	}

	void Turn()
	{
		if (Mathf.Abs (turnInput) > inputDelay) {
			// rotate
			targetRotation *= Quaternion.AngleAxis (rotateVel * turnInput * Time.deltaTime, Vector3.up); // rotate on global Y axis
		}
		transform.rotation = targetRotation;
	}
}
