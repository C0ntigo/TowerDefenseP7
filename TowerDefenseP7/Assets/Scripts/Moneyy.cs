using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Moneyy : MonoBehaviour
{
    public static int playerMoney;
    public int startMoney = 1;
    public TextMeshProUGUI moneyText;
    // Start is called before the first frame update
    void Start()
    {
        playerMoney = startMoney;
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateMoneyUI();
    }
    public void UpdateMoneyUI()
    {
        moneyText.text = "$" + Playerlives.Money.ToString();
    }
}
