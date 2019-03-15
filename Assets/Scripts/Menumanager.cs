using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menumanager : MonoBehaviour
{
    public List<GameObject> MenuList;
    public Transform parent;

    private GameObject MenuContainers;

    // Start is called before the first frame update
    void Start()
    {
        MenuContainers = new GameObject();
        ActivateMenu(0);

        foreach (GameObject menu in MenuList)
        {
            if(menu != null)
            {
                menu.transform.SetParent(MenuContainers.transform);
            }
        }
    }

    public void ActivateMenu(int menuID)
    {
        foreach( var menu in MenuList)
        {
            if(menu != null)
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
