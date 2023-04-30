using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class PlayerManager : MonoBehaviour
{
    public MyClass myClass = new MyClass();

    string saveFilePath;
    void Awake()
    {
        saveFilePath = $"{Application.persistentDataPath}/savesadsadata.json";
    }

    [ContextMenu("Save")]
    public void SavePlayerData()
    {
        string saveDataString = JsonUtility.ToJson(myClass);

        File.WriteAllText(saveFilePath, saveDataString);

        Debug.Log(saveFilePath);
    }
}