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
    public int GiveDex(int dext)
    {
        currentDext += dext;
        return this.currentDext;
    }
    public int TakeDex(int dext)
    {
        currentDext -= dext;
        return this.currentDext;
    }
}
