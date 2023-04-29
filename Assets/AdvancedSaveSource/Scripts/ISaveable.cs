using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISaveable
{
    object SaveData();

    void LoadData(object data);
}
