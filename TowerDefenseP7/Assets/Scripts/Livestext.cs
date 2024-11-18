using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Livestext : MonoBehaviour
{
    public TextMeshProUGUI livesText;


    void Update ()
    {
        livesText.text = Playerlives.Lives.ToString() + " Lives ";
    }
}
