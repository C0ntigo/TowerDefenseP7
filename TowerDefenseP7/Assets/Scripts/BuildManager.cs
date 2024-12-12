using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
   
    [SerializeField] GameObject RaccoonPrefab;

    void Start()
    {
            
    }

     void Update()
    {

        if(Input.GetMouseButtonDown(0))
        {
            Vector2 spawnPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            GameObject g = Instantiate(RaccoonPrefab, (Vector2)spawnPosition, Quaternion.identity);
        }    
    }
}
