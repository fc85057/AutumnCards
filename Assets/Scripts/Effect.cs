using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewEffect", menuName = "Effect")]
public abstract class Effect : ScriptableObject
{

    // public Unit unit;

    public abstract void Apply(Unit unit);

    protected void Damage(Unit unit, int damage)
    {
        unit.currentHealth -= damage;
    }

    protected void Heal(Unit unit, int healPoints)
    {
        unit.currentHealth += healPoints;
    }

    protected void Shield(Unit unit, int shieldPoints)
    {
        unit.currentShield += shieldPoints;
    }

}
