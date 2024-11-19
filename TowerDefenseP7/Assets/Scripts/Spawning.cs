using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning : MonoBehaviour
{
    private int OnionsLeft;

    private int enemies = 0;
    private int Wave = 0;
    private bool waveUI;
    private bool spawning = false;
    public GameObject[] Onions;
    public int OnionIndex;
    private Vector2 SpawnPos = new Vector2(-5f, -2.5f);
    private float startDelay = 1;
    private float repeatRate = 1;
   

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnOnions", startDelay, repeatRate);
    }
    void Update()
    {
        OnionsLeft = FindObjectsOfType<Enemy>().Length;
        if (waveUI && OnionsLeft == 0 && enemies == 0)
        {
            waveUI = true;
            Wave++;
        }
        if (!spawning && enemies > 0)
        {
            StarCourtaine(SpawnOnions());
        }
        if (waveUI && Input.GetKeyDown(KeyCode.Space))
        {
            waveStart();
        }
    }
    // Update is called once per frame

    void SpawnOnions()
    {
        spawning = true;
        if (enemies > 0) 
        {
            Instantiate(Onions[Random.Range(0, Onions.Length)], SpawnPos, transform.rotation);
        }
    }
    public void waveStart() 
    
    {

        enemies = 2000 + Wave;
        waveUI = false;
    }
}
