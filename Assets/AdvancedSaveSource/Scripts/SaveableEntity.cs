using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SaveableEntity : MonoBehaviour
{
    // We need a unique Id for saveable object
    public string Id = ""; 

    public void CreateID()
    {
        // If there is no Id, create one
        if(Id.Length == 0)
        { 
            Id = Guid.NewGuid().ToString();
        }
    }
}
