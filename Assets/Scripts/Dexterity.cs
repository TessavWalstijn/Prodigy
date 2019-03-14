using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dexterity
{
    public int startingDext = 50;
    public int dextAmount = 10;
    public int currentDext;
    
    public Dexterity()
    {
        currentDext = startingDext;
    }
    public int GiveDext()
    {
        return ++this.currentDext;
    }
    public int TakeDext()
    {
        return --this.currentDext;
    }
}
