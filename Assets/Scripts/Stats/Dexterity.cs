using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dexterity
{
    public int startingDext = 5;
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
