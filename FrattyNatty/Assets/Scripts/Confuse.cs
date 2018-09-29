using UnityEngine;
using System;

public class Confuse : MonoBehaviour
{

  public UnityEngine.UI.Text m_Text;
  public LayerMask m_DamageMask;
  public LayerMask m_HealthMask;

  public float m_Damage = 10f;
  private void OnTriggerEnter (Collider other)
  {
    // Collect all the colliders in a sphere from the shell's current position to a radius of the explosion radius.
    Collider[] colliders = Physics.OverlapSphere (transform.position, 5f, m_DamageMask);

    for (int i = 0; i < Math.Min(1,colliders.Length); i++) {

      Rigidbody targetRigidbody = gameObject.GetComponent<Rigidbody> ();
      if (!targetRigidbody)
        return;

      StudentStats targetHealth = targetRigidbody.GetComponent<StudentStats> ();
      if (!targetHealth)
        return;

      float damage = m_Damage;

      Debug.Log ("Take damage");
      targetHealth.TakeDamage (damage);
      Destroy (colliders [i]);
      return;
    }
      
    colliders = Physics.OverlapSphere (transform.position, 2f, m_HealthMask);
    Debug.Log ("Health colliders");
    Debug.Log (colliders.Length);
    for (int i = 0; i < Math.Min(1,colliders.Length); i++) {

      Rigidbody targetRigidbody = gameObject.GetComponent<Rigidbody> ();
      if (!targetRigidbody)
        return;

      StudentStats targetHealth = targetRigidbody.GetComponent<StudentStats> ();
      if (!targetHealth)
        return;
      Debug.Log ("Gain Health");
      targetHealth.GainHealth (10);
      Destroy (colliders [i]);
    }

  }

 

}