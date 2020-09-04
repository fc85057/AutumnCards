using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{

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
        energyCost.text = energyCost.ToString();
        icon.sprite = card.icon;
        image.sprite = card.image;

    }

    public void OnClick()
    {
        card.PlayCard();
    }

 
}
