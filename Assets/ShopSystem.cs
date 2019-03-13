using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopSystem : MonoBehaviour
{
    public float Strength = 10;
    public float Dexterity = 10;
    public float godlyFavour = 50;
    public float devilishFavour = 50;

    public GameObject StrengthButton;
    public GameObject DexterityButton;
    public GameObject EStrengthButton;
    public GameObject EDexterityButton;

    // Start is called before the first frame update
    void Start()
    {       
        
    }

    public void BuyStrength()
    {
        if (godlyFavour <= 50)
        {
            StrengthButton.SetActive(false);
        }

        Strength += 15;
        Dexterity -= 5;

        godlyFavour -= 50;

        print(Strength);
        print(Dexterity);
        print(godlyFavour);
        print(devilishFavour);
    }

    public void BuyDexterity()
    {
        if (godlyFavour <= 50)
        {
            DexterityButton.SetActive(false);
        }

        Dexterity += 15;
        Strength -= 5;

        godlyFavour -= 50;

        print(Strength);
        print(Dexterity);
        print(godlyFavour);
        print(devilishFavour);
    }

    public void BuyEvilStrength()
    {
        if (devilishFavour <= 50)
        {
            EStrengthButton.SetActive(false);
        }

        Strength += 25;
        Dexterity -= 20;

        devilishFavour -= 50;

        print(Strength);
        print(Dexterity);
        print(godlyFavour);
        print(devilishFavour);

    }

    public void BuyEvilDexterity()
    {
        if (devilishFavour <= 50)
        {
            EDexterityButton.SetActive(false);
        }

        Dexterity += 25;
        Strength -= 20;

        devilishFavour -= 50;

        print(Strength);
        print(Dexterity);
        print(godlyFavour);
        print(devilishFavour);
    }
}
