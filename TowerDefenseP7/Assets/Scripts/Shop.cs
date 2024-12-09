using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public int startMoney = 1;
    public static int Money;
    public int isRaccoonSold;

    public TextMeshPro raccoonPrice;

    public Button BuyButton;

     void Start()
    {
        
       Money = startMoney;
    }
     void Update()
    {
        isRaccoonSold = PlayerPrefs.GetInt("IsRaccoonSold");
        if (Money >= 2 && isRaccoonSold == 0)
        {

        }
    }
    public void BuyRaccoon ()
    {
        Money -= 2;
        PlayerPrefs.SetInt("IsRaccoonSold", 1);
    }
}
