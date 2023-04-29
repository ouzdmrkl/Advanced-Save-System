using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SerializeField]
public class Player
{
    public string playerName;
    public int playerLevel;
    public bool playerIsSelectable;

    public Player(string name, int level, bool selectable)
    {
        playerName = name;
        playerLevel = level;
        playerIsSelectable = selectable;
    }
}
