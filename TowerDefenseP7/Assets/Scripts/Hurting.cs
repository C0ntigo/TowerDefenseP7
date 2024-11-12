using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hurting : MonoBehaviour
{
    public int health;
    public int maxHealth = 150;

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }
     void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }


}
