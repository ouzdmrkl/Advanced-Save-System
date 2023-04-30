using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class MyClass
{
    public int level;
    public float timeElapsed;
    public string playerName;

    public List<Arabam> arabamList = new List<Arabam>();
}

[Serializable]
public class Arabam
{
    public string carName;
    public int price;
}
