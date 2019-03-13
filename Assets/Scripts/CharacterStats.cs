using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CharacterStats : MonoBehaviour
{
   public Button WealthButton;
   public Button DextButton;
   public Button StrengthButton;
    // Start is called before the first frame update
    void Start()
    {
        Strength myStrength = new Strength();
        Dexterity myDext = new Dexterity();
        Wealth myWealth = new Wealth();

        StrengthButton.onClick.AddListener(()=>
        {
            int tmp = myStrength.GiveStrength();
            Debug.Log($"Strengh is {tmp}");
        });
        DextButton.onClick.AddListener(()=>
        {
            int tmp = myDext.GiveDext();
            Debug.Log($"Dexterity is {tmp}");
        });
        WealthButton.onClick.AddListener(()=>
        {
            int tmp = myWealth.GiveWealth();
            Debug.Log($"Wealth is {tmp}");
        });

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
 