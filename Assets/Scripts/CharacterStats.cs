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
   public Image strengthImage;
  
  public Image DextImage;
  public Image IntelImage;
    // Start is called before the first frame update
    void Start()
    {
        strengthImage.fillAmount = 0;
        Strength myStrength = new Strength();
        Dexterity myDext = new Dexterity();
        Intelligence myIntel = new Intelligence();

        StrengthButton.onClick.AddListener(()=>
        {
            int StrAdd = myStrength.Give(StatIncrease);
            Debug.Log($"Strengh is {StrAdd}");
            strengthImage.fillAmount = Map((float)StrAdd, 0, 10, 0, 1);

            int DexTake = myDext.Take(StatDecrease);
            Debug.Log($"Dexterity is {DexTake}");
            DextImage.fillAmount = Map((float)DexTake, 0, 10, 0, 1);
        });
        DextButton.onClick.AddListener(()=>
        {
            int DexAdd = myDext.Give(StatIncrease);
            Debug.Log($"Dexterity is {DexAdd}");
            DextImage.fillAmount = Map((float)DexAdd, 0, 10, 0, 1);

            int StrTake = myStrength.Take(StatDecrease);
            Debug.Log($"Strengh is {StrTake}");
            strengthImage.fillAmount = Map((float)StrTake, 0, 10, 0, 1);
        });
        WealthButton.onClick.AddListener(()=>
        {
            int IntAdd = myIntel.Give(StatIncrease);
            Debug.Log($"Wealth is {Map(IntAdd, 0, 10, 0, 1)}");
            IntelImage.fillAmount = Map((float)IntAdd, 0, 10, 0, 1);
        });

    }
    private float Map (float input, float start1, float stop1, float start2, float stop2)
    {
        return (input - start1) / (stop1 - start1) * (stop2 - start2) + start2;
    }
}
 