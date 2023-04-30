using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SaveLoadManager
{
    // Methods
    public static void SaveData(object saveObject, string id)
    {
        string fileName = id + ".json";

        string saveFilePath = Application.persistentDataPath + "/" + fileName;

        string saveDataString = JsonUtility.ToJson(saveObject);

        File.WriteAllText(saveFilePath, saveDataString);

        Debug.Log(saveFilePath);
    }

    public static string LoadData(string id)
    {
        string fileName = id + ".json";

        string loadFilePath = Application.persistentDataPath + "/" + fileName;

        string loadedDataString = File.ReadAllText(loadFilePath);

        return loadedDataString;
    }
}
