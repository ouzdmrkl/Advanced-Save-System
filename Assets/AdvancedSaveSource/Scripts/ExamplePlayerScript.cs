using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExamplePlayerScript : MonoBehaviour
{
    public ExamplePlayerData playerData;

    [ContextMenu("Save")]
    public void Save()
    {
        // You need to ad SaveableEntity as a child and get the id
        string id = GetComponent<SaveableEntity>().Id;

        // To save  
        SaveLoadManager.SaveData(playerData, id);
    }

    [ContextMenu("Load")]
    public void Load()
    {
        string id = GetComponent<SaveableEntity>().Id;

        // To load data
        playerData = JsonUtility.FromJson<ExamplePlayerData>(SaveLoadManager.LoadData(id));
    }
}

[Serializable]
public class ExamplePlayerData
{
    public string playerName;
    public int playerMoney;
    public List<ExamplePlayerItems> items;
}

[Serializable]
public class ExamplePlayerItems
{
    public string itemName;
    public int itemPrice;
}
