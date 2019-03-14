using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Strength
{
    public int startingStrength = 50;
    public int currentStrength;  
    
    public Strength()
    {
        currentStrength = startingStrength;
        
    }

    public int GiveStrength()
    {
        return ++this.currentStrength;
    }
    public int TakeStrength()
    {
        return --this.currentStrength;
    }
}
