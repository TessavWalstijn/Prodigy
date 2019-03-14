using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopSystem : MonoBehaviour
{
    // devil deals Strenght + int
    //

    private const int COST = 5;

    public Button IntelligenceButton, DexterityButton, EStrengthButton, EIntelligenceButton;

    private Favour myFavour = new Favour();
    private Strength myStrength = new Strength();
    private Dexterity myDexterity = new Dexterity();
    private Intelligence myIntelligence = new Intelligence();

    private void Start()
    {
        FavourCheck();
    }

    public void BuyIntelligence()
    {
        myFavour.currentFavour -= COST;

        myIntelligence.GiveIntel(1);
        myDexterity.TakeDex(1);
        FavourCheck();
    }

    public void BuyDexterity()
    {
        myFavour.currentFavour -= COST;
        myDexterity.GiveDex(1);

        myIntelligence.TakeIntel(1);
        FavourCheck();
    }

    public void BuyEvilStrength()
    {
        myFavour.currentFavour += COST;

        myStrength.GiveStrength(2);

        myIntelligence.TakeIntel(1);
        myDexterity.TakeDex(1);
        FavourCheck();
    }

    private void FavourCheck()
    {
        bool condition = myFavour.currentFavour < COST;
        
        IntelligenceButton.interactable = !condition;
        DexterityButton.interactable = !condition;

        condition = myFavour.currentFavour > -COST;

        EStrengthButton.interactable = !condition;
        EIntelligenceButton.interactable = !condition;
    }

    public void BuyEvilIntelligence()
    {
        myFavour.currentFavour += COST;

        myIntelligence.GiveIntel(2);

        myStrength.TakeStrength(1);
        myDexterity.TakeDex(1);
        FavourCheck();
    }
}
