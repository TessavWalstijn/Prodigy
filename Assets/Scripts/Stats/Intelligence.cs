using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intelligence
{
    public int startingIntel = 50;
    public int currentIntel;
    public Intelligence()
    {
        currentIntel = startingIntel;
    }
    public int GiveIntel(int intel)
    {
        currentIntel += intel;
        return this.currentIntel;
    }
    public int TakeIntel(int intel)
    {
        currentIntel -= intel;
        return this.currentIntel;
    }
}
