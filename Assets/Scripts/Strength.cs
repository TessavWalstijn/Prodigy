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
        Debug.Log("startScript");
        currentStrength = startingStrength;
        
    }

    public int GiveStrength()
    {
        Debug.Log(" hello addStrength");
        return ++this.currentStrength;
    }
}
