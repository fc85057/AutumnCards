using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum BattleStatus { BattleStart, PlayerTurn,
    EnemyTurn, BattleWin, BattleLose }

public class BattleManager : MonoBehaviour
{

    public CardManager cardManager;
    public UIManager uiManager;

    public Unit playerUnit;
    public Unit enemyUnit;
    private Player player;
    private Enemy enemy;

    private BattleStatus currentStatus;
    private bool canPlayCard;

    // Start is called before the first frame update
    void Start()
    {
        currentStatus = BattleStatus.BattleStart;
        BattleStart();
    }

    void BattleStart()
    {
        cardManager.InstantiateDeckTest();
        player = playerUnit.GetComponent<Player>();
        enemy = enemyUnit.GetComponent<Enemy>();
        currentStatus = BattleStatus.PlayerTurn;
        PlayerTurn();
    }

    void PlayerTurn()
    {
        canPlayCard = true;
        foreach (Effect effect in player.effects)
        {
            effect.Apply(player);
            // UI needs to be updated
        }
        player.currentEnergy = player.maxEnergy;
    }

    IEnumerator EnemyTurn()
    {
        Debug.Log("Enemy is taking turn");
        yield return new WaitForSeconds(5f);
        currentStatus = BattleStatus.PlayerTurn;
    }

    public void CardClicked(Card card)
    {
        if (currentStatus == BattleStatus.PlayerTurn
            && canPlayCard)
        {
            StartCoroutine(PlayCard(card));
        }
    }

    public void EndTurn()
    {
        if (currentStatus == BattleStatus.PlayerTurn)
        {
            currentStatus = BattleStatus.EnemyTurn;
            StartCoroutine(EnemyTurn());
        }
    }

    IEnumerator PlayCard(Card card)
    {
        if (player.currentEnergy >= card.energyCost)
        {
            canPlayCard = false;
            card.PlayCard();
            player.currentEnergy -= card.energyCost;
        }
        else
        {
            Debug.Log("Not enough energy");
        }
        uiManager.UpdateUI(player, enemy);
        yield return new WaitForSeconds(2f);
        canPlayCard = true;
    }

}
