using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewCard", menuName = "HealCard")]
public class HealCard : Card
{
    public int healPoints = 10;

    public override void PlayCard()
    {
        Heal(healPoints);
    }
}
