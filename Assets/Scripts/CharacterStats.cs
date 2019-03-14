using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CharacterStats : MonoBehaviour
{
    [SerializeField]
    private int StatIncrease;
    [SerializeField]
    private int StatDecrease;
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
        Intel myWealth = new Intel();

        StrengthButton.onClick.AddListener(()=>
        {
            int StrAdd = myStrength.Give(StatIncrease);
            //int DexTake = myDext.Take(StatDecrease);
            //Debug.Log($"Dexterity is {DexTake}");
            Debug.Log($"Strengh is {StrAdd}");
            StrTxt.text = "Strength" + StrAdd;
        });
        DextButton.onClick.AddListener(()=>
        {
            int DexAdd = myDext.Give(StatIncrease);
            Debug.Log($"Dexterity is {DexAdd}");
            DexTxt.text = "Dexterity" + DexAdd;
        });
        WealthButton.onClick.AddListener(()=>
        {
            int IntAdd = myWealth.GiveIntel(StatIncrease);
            Debug.Log($"Wealth is {IntAdd}");
            WltTxt.text = "Intel" + IntAdd;
        });

    }
}
 