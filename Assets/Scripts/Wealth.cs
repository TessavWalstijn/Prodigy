using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wealth
{
    public int startingWealth = 50;
    public int currentWealth;
    public Wealth()
    {
        currentWealth = startingWealth;
    }
    public int GiveWealth()
    {
        Debug.Log("hello addWealth");
        return ++this.currentWealth;
    }
}
