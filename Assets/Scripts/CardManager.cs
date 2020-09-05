using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CardManager : MonoBehaviour
{

    public GameObject card;
    public GameObject cardSlotsContainer;
    public List<Transform> cardSlots;

    public List<GameObject> deck;
    public List<GameObject> hand;
    public List<GameObject> drawPile;
    public List<GameObject> discardPile;

    public void InstantiateDeckTest()
    {
        foreach (Transform cardSlot in cardSlotsContainer.transform)
        {
            cardSlots.Add(cardSlot);
        }
        for (int i = 0; i < 5; i++)
        {
            GameObject newCardObject = Instantiate(card, cardSlots[i]);
            hand.Add(newCardObject);
        }
    }

    public void InitializeDeck()
    {
        foreach (Transform cardSlot in cardSlotsContainer.transform)
        {
            cardSlots.Add(cardSlot);
        }

        string[] cardPaths = {"AttackCardGust", "AttackCardPinecone", "AttackCardStorm",
        "AttackCardWind", "HealCardPumpkinJuice", "HealCardPumpkinLager"};
        List<Card> possibleCards = new List<Card>();

        foreach (string path in cardPaths)
        {
            Card possibleCard = (Card)AssetDatabase.LoadAssetAtPath("Assets/Cards/" + path + ".asset", typeof(Card));
            possibleCards.Add(possibleCard);
        }

        for (int i = 0; i < 12; i++)
        {
            Debug.Log(possibleCards.Count);
            foreach (var cardEntry in possibleCards)
            {
                Debug.Log(cardEntry.name);
            }
            Card newCardType = possibleCards[Random.Range(0, possibleCards.Count)];
            GameObject newCardObject = Instantiate(card);
            Debug.Log(newCardType);
            newCardObject.GetComponent<CardDisplay>().card = newCardType;
            deck.Add(newCardObject);
        }

        for (int i = 0; i < 5; i++)
        {
            // deck[i].transform.position = cardSlots[i].transform.position;
            deck[i].transform.SetParent(cardSlots[i], false);
        }
    }

}
