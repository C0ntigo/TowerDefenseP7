using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGray : MonoBehaviour
{
    [SerializeField] GameObject Raccoon;
    [SerializeField] GameObject Raccoon1;
    [SerializeField] GameObject Raccoon2;
    [SerializeField] GameObject Raccoon3;
    [SerializeField] GameObject Raccoon4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
   public  void Spawning()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 spawnPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            GameObject g = Instantiate(Raccoon, (Vector2)spawnPosition, Quaternion.identity);
            GameObject g1 = Instantiate(Raccoon1, (Vector2)spawnPosition, Quaternion.identity);
            GameObject g2 = Instantiate(Raccoon2, (Vector2)spawnPosition, Quaternion.identity);
            GameObject g3 = Instantiate(Raccoon3, (Vector2)spawnPosition, Quaternion.identity);
            GameObject g4 = Instantiate(Raccoon4, (Vector2)spawnPosition, Quaternion.identity);
        }
    }
}
