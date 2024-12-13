using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class BuildManager : MonoBehaviour
{
    private bool isSelected = false;
    public Button toggleButton;
    public GameObject prefabToInstantiate;
   // [SerializeField] GameObject RaccoonPrefab;
    public TextMeshProUGUI buttonText;

    void Start()
    {
        toggleButton.onClick.AddListener(ToggleSelection);
    }

     void Update()
    {

        if(isSelected && Input.GetMouseButtonDown(0))
        {
            
            Vector2 spawnPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Instantiate(prefabToInstantiate, spawnPosition, Quaternion.identity);
        }    
    }

    void ToggleSelection()
    {
        isSelected = !isSelected;
        UpdateButtonText();
    }

    void UpdateButtonText()
    {
        buttonText.text = isSelected ? "Selected" : "Not Selected";
    }
}
