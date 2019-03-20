using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menumanager : MonoBehaviour
{
    public List<GameObject> MenuList;

    // Start is called before the first frame update
    void Start()
    {
        ActivateMenu(0);
    }

    public void ActivateMenu(int menuID)
    {
        foreach (var menu in MenuList)
        {
            if (menu != null)
            {
                menu.SetActive(false);
            }
        }

        if (MenuList[menuID] != null)
        {
            MenuList[menuID].SetActive(true);
        }
    }
}