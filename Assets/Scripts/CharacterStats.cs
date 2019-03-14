using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CharacterStats : MonoBehaviour
{
   public Button WealthButton;
   public Button DextButton;
   public Button StrengthButton;
   public Text StrTxt;
   public Text DexTxt;
   public Text WltTxt;
    // Start is called before the first frame update
    void Start()
    {
        Strength myStrength = new Strength();
        Dexterity myDext = new Dexterity();
        Wealth myWealth = new Wealth();

        StrengthButton.onClick.AddListener(()=>
        {
            int StrAdd = myStrength.GiveStrength();
            int DexTake = myDext.TakeDext();
            Debug.Log($"Dexterity is {DexTake}");
            Debug.Log($"Strengh is {StrAdd}");
            StrTxt.text = "Strength" + StrAdd;
        });
        DextButton.onClick.AddListener(()=>
        {
            int DexAdd = myDext.GiveDext();
            Debug.Log($"Dexterity is {DexAdd}");
            DexTxt.text = "Dexterity" + DexAdd;
        });
        WealthButton.onClick.AddListener(()=>
        {
            int WltAdd = myWealth.GiveWealth();
            Debug.Log($"Wealth is {WltAdd}");
            WltTxt.text = "Wealth" + WltAdd;
        });

    }
}
 