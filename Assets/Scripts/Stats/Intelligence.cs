using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intelligence
{
    public int startingIntel = 5;
    public int currentIntel;
    public Intelligence()
    {
        currentIntel = startingIntel;
    }
    public int Give(int intel)
    {
        currentIntel += intel;
        return this.currentIntel;
    }
    public int Take(int intel)
    {
        currentIntel -= intel;
        return this.currentIntel;
    }
}