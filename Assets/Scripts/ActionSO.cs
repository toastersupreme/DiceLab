//Script for Dice Lab by Roni and Willem "Oct 19th 2022"
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
[CreateAssetMenu (menuName = "Action/Create Action", fileName = "Action_", order = 1)]
public class ActionSO : ScriptableObject
{
    public string actionName;
    public Sprite sprite;
}
