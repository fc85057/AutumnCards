using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

 public abstract class Card : ScriptableObject
{

    public new string name;
    public string description;
    public int energyCost;
    public Sprite icon;
    public Sprite image;

    public abstract void PlayCard();


    protected void Attack(int damage)
    {
        Debug.Log("Attacking and doing " + damage + " damage");
        /*
        Text enemyHealth = GameObject.Find("EnemyHealth").GetComponent<Text>();
        int enemyHealthInt = int.Parse(enemyHealth.text);
        int newHealth = enemyHealthInt - damage;
        enemyHealth.text = newHealth.ToString();
        */
        int playerStrength = FindObjectOfType<Player>().currentStrength;
        FindObjectOfType<Enemy>().TakeDamage(damage + playerStrength);

    }

    protected void Heal(int healthPoints)
    {
        Debug.Log("Heal");
        /*
        Text playerHealth = GameObject.Find("PlayerHealth").GetComponent<Text>();
        int playerHealthInt = int.Parse(playerHealth.text);
        int newHealth = playerHealthInt + healthPoints;
        playerHealth.text = newHealth.ToString();
        */
        FindObjectOfType<Player>().currentHealth += healthPoints;
    }
    
    protected void Shield(int shieldPoints)
    {
        Debug.Log("Adding shield points");
    }

    protected void ApplyEffect(Unit unit, Effect effect)
    {
        Debug.Log("Adding effect");
        unit.effects.Add(effect);
    }

}
