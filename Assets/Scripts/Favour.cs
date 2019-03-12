using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Favour : MonoBehaviour
{
    public int startingfavour = 0;
    public int currentFavour;  
    public Button FavButton;
    void Start()
    {
        Debug.Log("startScript");
        currentFavour = startingfavour;
        //SetCountText ();
        FavButton.onClick.AddListener(GiveFav);
    }

    void GiveFav()
    {
        Debug.Log(" hello addFavour");
        
    }
    public override void AddFav()
    {
        
    }
}
