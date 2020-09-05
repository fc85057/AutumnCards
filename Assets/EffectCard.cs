using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewCard", menuName = "EffectCard")]
public class EffectCard : Card
{
    public Unit unit;
    public Effect effect;
    
    public override void PlayCard()
    {
        ApplyEffect(unit, effect);
    }

}
