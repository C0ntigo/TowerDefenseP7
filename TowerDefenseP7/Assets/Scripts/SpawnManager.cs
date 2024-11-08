using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public Transform enemyPrefab;
    public float SpawnTime = 5f;
    public float countdown = 2f;
    private int waveNumber = 1;
    public Transform spawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (countdown <= 0)
        {
            SpawnWave();
            countdown = SpawnTime;
        }
        countdown -= Time.deltaTime;
    }
    IEnumerator SpawnWave ()
    {
        for (int i = 0; i < waveNumber; i++) 
        {
            SpawnEnemy();
            yield return new WaitForSeconds(0.5f);
        }
        Debug.Log("Onions Have Arrived");
        waveNumber++;
    }
    void SpawnEnemy ()
    {
        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}
