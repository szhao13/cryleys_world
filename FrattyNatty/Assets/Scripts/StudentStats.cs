using UnityEngine;
using UnityEngine.UI;
using System;

public class StudentStats : MonoBehaviour
{
  public float m_StartingHealth = 100f;               // The amount of health each tank starts with.
  public Slider m_Slider;                             // The slider to represent how much health the tank currently has.
  public Image m_FillImage;                           // The image component of the slider.
  public Color m_FullHealthColor = Color.green;       // The color the health bar will be when on full health.
  public Color m_ZeroHealthColor = Color.red;         // The color the health bar will be when on no health.

  public GameObject m_RestartButton;
  public GameObject m_TimeText;

  private float m_CurrentHealth;                     
  private bool m_Dead;                
  private float m_StartTime;


  public void OnEnable()
  {
    m_RestartButton.SetActive (false);
    m_TimeText.SetActive (false);

    transform.position = new Vector3(5,transform.position.y+1,1); 
    m_CurrentHealth = m_StartingHealth;
    m_Dead = false;
    gameObject.SetActive (true);
    SetHealthUI();

    m_StartTime = Time.timeSinceLevelLoad;
  }


  public void TakeDamage (float amount)
  {
    m_CurrentHealth -= amount;

    SetHealthUI ();

    if (m_CurrentHealth <= 0f && !m_Dead)
    {
      OnDeath ();
    }
  }

  public void GainHealth (float amount)
  {
    TakeDamage (-amount);
    if (m_CurrentHealth >= m_StartingHealth)
      m_CurrentHealth = m_StartingHealth;
  }


  private void SetHealthUI ()
  {
    // Set the slider's value appropriately.
    m_Slider.value = m_CurrentHealth;

    // Interpolate the color of the bar between the choosen colours based on the current percentage of the starting health.
    m_FillImage.color = Color.Lerp (m_ZeroHealthColor, m_FullHealthColor, m_CurrentHealth / m_StartingHealth);
  }


  private void OnDeath ()
  {
    // Set the flag so that this function is only called once.
    m_Dead = true;

    // Turn the tank off.
    gameObject.SetActive (false);
    m_RestartButton.SetActive (true);
    m_TimeText.SetActive (true);

    float elapsedTime = Time.timeSinceLevelLoad - m_StartTime;
    m_TimeText.GetComponent<Text>().text = elapsedTime + "s";

    Debug.Log (Time.timeSinceLevelLoad);
  }


}