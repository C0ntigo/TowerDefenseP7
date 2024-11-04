using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Makers : MonoBehaviour
{

    public static Transform[] Phil;
    // Start is called before the first frame update
    void Awake()
    {
        Phil = new Transform[transform.childCount];
        for (int i = 0; i < Phil.Length; i++)
        {
            Phil[i] = transform.GetChild(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
