using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class SaveAndLoadAdvanced : MonoBehaviour
{
    private string savePath => $"{Application.persistentDataPath}/save.txt";

    [ContextMenu("Save")]
    public void Save()
    {
        var data = LoadFile();
        SaveData(data);
        SaveFile(data);
    }

    [ContextMenu("Load")]
    public void Load()
    {
        var data = LoadFile();
        LoadData(data);
    }

    private void SaveFile(object data)
    {
        using (var stream = File.Open(savePath, FileMode.Create))
        {
            var formatter = new BinaryFormatter();
            formatter.Serialize(stream, data);
        }
    }

    private Dictionary<string, object> LoadFile()
    {
        if(!File.Exists(savePath))
        {
            return new Dictionary<string, object>();
        }

        using (FileStream stream = File.Open(savePath, FileMode.Open))
        {
            var formatter = new BinaryFormatter();
            return (Dictionary<string, object>)formatter.Deserialize(stream);
        }
    }

    private void SaveData(Dictionary<string, object> data)
    {
        foreach(var saveable in FindObjectsOfType<SaveableEntity>())
        {
            data[saveable.Id] = saveable.SaveAllData();
        }
    }

    private void LoadData(Dictionary<string, object> data)
    {
        foreach (var saveable in FindObjectsOfType<SaveableEntity>())
        {
            if(data.TryGetValue(saveable.Id, out object value))
            {
                saveable.LoadAllData(data);
            }
        }
    }
}
