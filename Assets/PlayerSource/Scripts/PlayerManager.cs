using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour, ISaveable // NEED TO ADD "ISAVEABLE" INTERFACE
{
    // I have created player in here
    //public Player newPlayer = new Player("Mikey", 2, true);
    
    public string playerName;
    public int playerLevel;
    public bool playerIsSelectable;

    public void LoadData(object data)
    {
        var playerSaveData = (PlayerSaveData)data;

        playerName = playerSaveData.playerName;
        playerLevel = playerSaveData.playerLevel;
        playerIsSelectable = playerSaveData.playerIsSelectable;
    }

    public object SaveData()
    {
        return new PlayerSaveData
        {
            playerName = playerName,
            playerLevel = playerLevel,
            playerIsSelectable = playerIsSelectable
        };
    }
}

// You need to create a struct to declare what data you want to save
[SerializeField]
public struct PlayerSaveData
{
    public string playerName;
    public int playerLevel;
    public bool playerIsSelectable;
}
