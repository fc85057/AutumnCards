using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewCard", menuName = "AttackCard")]
public class AttackCard : Card
{

    public int damage = 5;

    public override void PlayCard()
    {
        Attack(damage);
    }
}
