using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dexterity
{
    public int startingDext = 50;
    public int currentDext;
    
    public Dexterity()
    {
        currentDext = startingDext;
    }
    public int GiveDext()
    {
        Debug.Log("hello addDext");
        return ++this.currentDext;
    }
}
