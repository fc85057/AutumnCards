﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    public Text playerHealthText;
    public Text enemyHealthText;
    public Text playerEnergyText;

    

    public void UpdateUI(Player player, Enemy enemy)
    {
        playerHealthText.text = player.currentHealth.ToString();
        enemyHealthText.text = enemy.currentHealth.ToString();
        playerEnergyText.text = player.currentEnergy.ToString();
    }

}
