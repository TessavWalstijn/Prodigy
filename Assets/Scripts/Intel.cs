using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intel
{
    public int startingIntel = 50;
    public int currentIntel;
    public Intel()
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
