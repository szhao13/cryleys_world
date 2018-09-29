using UnityEngine;
using System;

public class Confuse : MonoBehaviour
{
	//public AudioSource m_ExplosionAudio;
	public UnityEngine.UI.Text m_Text;
	public LayerMask m_TankMask;
	// Used to filter what the explosion affects, this should be set to "Players".

	public float m_MaxDamage = 30f;
	// The amount of damage done if the explosion is centred on a tank.

	private void Start ()
	{
		Debug.Log("Start");
	}

	private void OnTriggerEnter (Collider other)
	{
		Debug.Log ("Collide");

		// Find the collider's rigidbody.
		Rigidbody targetRigidbody = other.GetComponent<Rigidbody> ();

		// If they don't have a rigidbody, go on to the next collider.
		if (!targetRigidbody)
			return;

		// Find the TankHealth script associated with the rigidbody.
		StudentStats targetHealth = targetRigidbody.GetComponent<StudentStats> ();

		// If there is no TankHealth script attached to the gameobject, go on to the next collider.
		if (!targetHealth)
			return;

		// Calculate the amount of damage the target should take based on it's distance from the shell.
		float damage = m_MaxDamage;

		//m_ExplosionAudio.Play();
		//StartCoroutine(m_Text.BroadcastMessage("A pixel"), 2);

		GUI.Box (new Rect(0,0,100,100),"Well done!!");

		// Deal this damage to the tank.
		targetHealth.TakeDamage (damage);
	}

}