using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(SaveableEntity))]
public class SaveLoadEditor : Editor
{
    // Used default methods to add inspector button
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        SaveableEntity saveableEntityScript = (SaveableEntity)target;

        if (GUILayout.Button("Create GUID"))
        {
            saveableEntityScript.CreateID();
        }
    }
}
