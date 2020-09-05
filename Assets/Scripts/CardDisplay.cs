using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{

    public Player player;
    public BattleManager battleManager;

    public Card card;

    public Text cardName;
    public Text description;
    public Text energyCost;
    public Image icon;
    public Image image;

    void Start()
    {

        cardName.text = card.name;
        description.text = card.description;
        energyCost.text = card.energyCost.ToString();
        icon.sprite = card.icon;
        image.sprite = card.image;

    }

    public void OnClick()
    {
        //if (player.currentEnergy >= card.energyCost)
        //    card.PlayCard();
        FindObjectOfType<BattleManager>().CardClicked(card);
        // battleManager.PlayCard(card);
    }

 
}
