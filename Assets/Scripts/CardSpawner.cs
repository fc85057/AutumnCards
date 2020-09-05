using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class CardSpawner : MonoBehaviour
{

    public GameObject card;
    public ScriptableObject cardDetails;

    // Start is called before the first frame update
    void Start()
    {
        var cardInfo = card.GetComponent<CardDisplay>();
        var test = ScriptableObject.CreateInstance<HealCard>();
        GameObject cardSlot = GameObject.Find("CardSlot4");
        GameObject newCard = Instantiate(card, cardSlot.transform);
        var cardDetails = newCard.GetComponent<CardDisplay>();
        cardDetails.card = (Card)AssetDatabase.LoadAssetAtPath("Assets/FirstHealCard.asset", typeof(Card));
    }
}
