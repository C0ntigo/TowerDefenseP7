using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    [SerializeField] GameObject RaccoonPrefab;
    [SerializeField] GameObject RaccoonPrefab1;
    [SerializeField] GameObject RaccoonPrefab2;
    [SerializeField] GameObject RaccoonPrefab3;
    [SerializeField] GameObject RaccoonPrefab4;

    void Start()
    {
            
    }

     void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector2 spawnPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            GameObject g = Instantiate(RaccoonPrefab, (Vector2)spawnPosition, Quaternion.identity);
             GameObject g1 = Instantiate(RaccoonPrefab1, (Vector2)spawnPosition, Quaternion.identity);
        }    
    }
}
