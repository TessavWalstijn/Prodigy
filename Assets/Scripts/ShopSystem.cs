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

        myIntelligence.Give(1);
        myDexterity.Take(1);
        FavourCheck();
    }

    public void BuyDexterity()
    {
        myFavour.currentFavour -= COST;
        myDexterity.Give(1);

        myIntelligence.Take(1);
        FavourCheck();
    }

    public void BuyEvilStrength()
    {
        myFavour.currentFavour += COST;

        myStrength.Give(2);

        myIntelligence.Take(1);
        myDexterity.Take(1);
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

        myIntelligence.Give(2);

        myStrength.Take(1);
        myDexterity.Take(1);
        FavourCheck();
    }
}