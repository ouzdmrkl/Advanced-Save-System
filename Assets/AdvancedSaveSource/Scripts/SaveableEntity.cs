using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveableEntity : MonoBehaviour
{
    // We create a UNIQUE id for saveable game objects to know which is which. 

    [SerializeField] private string id = string.Empty;

    public string Id => id;

    [ContextMenu("Generate unique ID")]
    private void GenerateId() => id = Guid.NewGuid().ToString();

    public object SaveAllData()
    {
        var data = new Dictionary<string, object>();

        foreach (var saveable in GetComponents<ISaveable>())
        {
            data[saveable.GetType().ToString()] = saveable.SaveData();
        }

        return data;
    }

    public void LoadAllData(object data)
    {
        var dataDictionary = (Dictionary<string, object>)data;

        foreach (var saveable in GetComponents<ISaveable>())
        {
            string typeName = saveable.GetType().ToString();

            if(dataDictionary.TryGetValue(typeName, out object value))
            {
                saveable.LoadData(value);
            }
        }
    }
}
