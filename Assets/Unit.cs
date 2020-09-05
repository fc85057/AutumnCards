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

    public List<Effect> effects;

    private void Start()
    {
        currentHealth = maxHealth;
        currentShield = 0;
        currentStrength = standardStrength;
        effects = new List<Effect>();
    }

}
