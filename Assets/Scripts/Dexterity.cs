using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dexterity
{
    public int startingDext = 10;
    public int dextAmount = 10;
    public int currentDext;
    
    public Dexterity()
    {
        currentDext = startingDext;
    }
    public int Give(int dext)
    {
        currentDext += dext;
        return this.currentDext;
    }
    public int Take(int dext)
    {
        currentDext -= dext;
        return this.currentDext;
    }
}
