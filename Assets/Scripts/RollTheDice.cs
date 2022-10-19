//Script for Dice Lab by Roni and Willem "Oct 19th 2022"
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class RollTheDice : MonoBehaviour
{
    public List<ActionSO> actionSO; //list of different actions

    public List<string> actionsUsed; //list of actions the player has used


    public int numOfActions;//number of actions the player has done
    public int numOfAttacks;
    public int numOfDefends;
    public int numOfRuns;
    public int numOfIdles;
    public int numOfWaits;

    public TextMeshProUGUI currentActionText;//displays the last rolled action on the screen
    public Image currentActionSprite;

    //rolls a number and then checks to see if said number is "dead"
    public void Roll()
    {
        int rolledNumber;

        rolledNumber = Random.Range(0, 6);

        //if rolled number equals dead, print the whole list, otherwise add the rolled action to the list
        if (rolledNumber == 5)
        {
            Dead();//calls dead method
            currentActionText.text = actionSO[rolledNumber].actionName;
            currentActionSprite.sprite = actionSO[rolledNumber].sprite;
        }
        else
        {
            //counter for each action
            if (rolledNumber == 0)
            {
                numOfAttacks++;
            }
            else if (rolledNumber == 1)
            {
                numOfDefends++;
            }
            else if (rolledNumber == 2)
            {
                numOfRuns++;
            }
            else if (rolledNumber == 3)
            {
                numOfWaits++;
            }
            else if (rolledNumber == 4)
            {
                numOfIdles++;
            }

            //adds the action to a new list
            actionsUsed.Add(actionSO[rolledNumber].actionName);
            numOfActions++;
            currentActionText.text = actionSO[rolledNumber].actionName;
            currentActionSprite.sprite = actionSO[rolledNumber].sprite;
        }
        
    }

    //method to display all of the actions that have been used so far
    public void Dead()
    {
        foreach (string action in actionsUsed)
        {
            print(action);
        }
        print("The player attacked "+ numOfAttacks + " time(s), defended " + numOfDefends + " time(s), ran " + numOfRuns + " time(s), waited "
            + numOfWaits + " time(s), and idled " + numOfIdles +  " time(s)." + "\nThe player did a total of " + numOfActions + " action(s) before dying!");

        numOfActions = 0;
        numOfAttacks = 0;
        numOfDefends = 0;
        numOfRuns = 0;
        numOfIdles = 0;
        numOfWaits = 0;

    actionsUsed.Clear();
    }

}
