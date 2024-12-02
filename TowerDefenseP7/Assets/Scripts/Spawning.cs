using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning : MonoBehaviour
{
    private int OnionsLeft;

    private int enemies = 0;
    private int Wave = 0;
    private bool waveUI = true;
    private bool spawning = false;
    public GameObject[] Onions;
    public int OnionIndex;
    private Vector2 SpawnPos = new Vector2(-5f, -2.5f);
    private float startDelay = 1;
    private float repeatRate = 1;
    public float midtime = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Update()
    {
        OnionsLeft = FindObjectsOfType<Enemy>().Length;
        Debug.Log("OnionsLefft: " + OnionsLeft);
        if (!waveUI && OnionsLeft == 0 && enemies == 0)
        {
            waveUI = true;
            Wave++;
        }
        if (!spawning && enemies > 0)
        {
            StartCoroutine(SpawnOnions());
        }
        if (waveUI && Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("wave: " + Wave);
            enemies = 2 + Wave;

            waveUI = false;
        }
    }
    // Update is called once per frame

     System.Collections.IEnumerator SpawnOnions()
    {
        spawning = true;
        if (enemies > 0) 
        {
            Instantiate(Onions[Random.Range(0, Onions.Length)], SpawnPos, transform.rotation);
            enemies--;
            Debug.Log(enemies);
            
        }
        if (enemies > 0)
        {
            yield return new WaitForSeconds(midtime);
        }
        else 
        {
           spawning = false;
            yield break;

        }
        spawning = false;
        
    }
    
}
