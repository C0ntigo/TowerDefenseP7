using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Hurting : MonoBehaviour
{
    public TextMeshPro livesText;
    private int lives;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void UpdateLives(int livesToChange)
    {
        lives += livesToChange;
        livesText.text = "Lives: " + lives;
        if (lives <= 0) 
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        }
    }
}
