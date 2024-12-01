using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GoHome : MonoBehaviour
{
    public void YouLike()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + -1);
    }
}
