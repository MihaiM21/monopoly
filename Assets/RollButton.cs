using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RollButton : MonoBehaviour
{
    public DiceScript diceScr;
    public Text diceText;
    public GameObject player;
    int dices,dice1,dice2;

    public void Start()
    {
        
    }

    public void RollDice()
    {
        dices = diceScr.RollTheDice(1);
        dice1 = dices / 10;
        dice2 = dices % 10;
        diceText.text = dice1.ToString() + " " + dice2.ToString();
        player.GetComponent<PlayerScript>().movePlayer(dice1+dice2);
    }
}
