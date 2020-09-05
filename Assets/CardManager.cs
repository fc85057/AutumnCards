using System.Collections;
using System.Collections.Generic;
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

}
