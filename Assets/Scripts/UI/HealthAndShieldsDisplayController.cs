﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

/// <summary>
/// Controller for health and shield UI displays.
/// </summary>
public class HealthAndShieldsDisplayController : MonoBehaviour
{
    Text healthDisplay, shieldsDisplay;
    bool hasInitialized;
	[SerializeField]
	Image healthBar;
	[SerializeField]
	Image shieldBar;

    void Start()
    {
        if (!hasInitialized)
            Initialiaze();
    }

    void Initialiaze()
    {
        if (!hasInitialized)
        {
            healthDisplay = transform.Find("HealthDisplay").GetComponent<Text>();
            shieldsDisplay = transform.Find("ShieldsDisplay").GetComponent<Text>();

            hasInitialized = true;
        }
    }

    public void SetHealth(int currentHP, int maxHP)
    {
        if (!hasInitialized)
            Initialiaze();

        healthDisplay.text = "Health: " + currentHP;
        healthDisplay.color = Color.Lerp(Color.red, Color.green, (float)currentHP / maxHP);
		if (healthBar != null) {
			healthBar.fillAmount = (float)(currentHP) / (float)(maxHP);
		}
    }

    public void SetShields(int currentShields, int maxShields)
    {
        if (!hasInitialized)
            Initialiaze();

        shieldsDisplay.text = "Shields: " + currentShields;
        shieldsDisplay.color = Color.Lerp(Color.white, Color.blue, (float)currentShields / maxShields);
		if (shieldBar != null) {
			shieldBar.fillAmount = (float)(currentShields) / (float)(maxShields);
		}
    }
}
