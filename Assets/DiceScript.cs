using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceScript : MonoBehaviour
{
    int dice1, dice2;

    public int RollTheDice(int fromWhere)
    {
        dice1 = Random.Range(1, 7);
        dice2 = Random.Range(1, 7);

        if(fromWhere == 1)//de la RollButon.cs
        {
            return dice1 + 10 * dice2;
        }
        if(fromWhere == 2)//de la PlayerScript
        {
            return dice1 + dice2;
        }
        return dice1 + dice2;

    }
}
