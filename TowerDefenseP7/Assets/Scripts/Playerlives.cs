using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerlives : MonoBehaviour
{
    public static int Money;
    public int startMoney = 1;

    public static int Lives;
    public int startLives = 2;
    // Start is called before the first frame update
    void Start()
    {
        Money = startMoney;
        Lives = startLives;
    }

    
}
