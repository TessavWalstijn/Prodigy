using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Strength
{
    public int startingStrength = 5;
    public int currentStrength;


    public Strength()
    {
        currentStrength = startingStrength;

    }

    public int Give(int str)
    {
        currentStrength += str;
        return this.currentStrength;
    }
    public int Take(int str)
    {
        currentStrength -= str;
        return this.currentStrength;
    }
}