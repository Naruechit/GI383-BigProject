using System;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    public Image healthImage;
    public Health health;
    
    public void SetHealth(int health)
    {
        healthImage.fillAmount = health / 100f;
    }

    public void Update()
    {
        SetHealth(health.currentHealth);
    }
}
