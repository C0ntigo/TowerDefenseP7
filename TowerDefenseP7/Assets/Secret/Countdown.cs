using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{

    public GoHome goHomeButton;
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float remainingTime;


     void Start()
    {
        goHomeButton.gameObject.SetActive(false);
    }
    void Update()
    {
        if (remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;
            int minutes = Mathf.FloorToInt(remainingTime / 60);
            int seconds = Mathf.FloorToInt(remainingTime % 60);
            timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
        else
        {
            remainingTime = 0;
            timerText.text = "00:00";
            goHomeButton.gameObject.SetActive(true);
        }
    }
   
}

