using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public int maxShield = 50;
    public int currentShield;

    public int standardStrength = 0;
    public int currentStrength;

    public int standardHealing = 0;
    public int currentHealing;

    public List<Effect> effects;

    private void Start()
    {
        currentHealth = maxHealth;
        currentShield = 0;
        currentStrength = standardStrength;
        currentHealing = standardHealing;
        effects = new List<Effect>();
    }

    public void TakeDamage(int damage)
    {
        for (int i = 0; i < damage; i++)
        {
            if (currentShield > 0)
            {
                currentShield--;
            }
            else
            {
                currentHealth--;
            }
        }
    }

}
