using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    public Color hoverColor;
    private Renderer rend;
    private Color startColor;
    public Vector2 positionOffset;

    public GameObject tower;

    BuildManager buildManager;
     void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;

        buildManager = BuildManager.instance;
    }
    public Vector2 GetBuildPosition ()
    {
        return transform.position + positionOffset;
    }
    void OnMouseEnter()
    {
        rend.material.color = hoverColor;

        
    }
     void OnMouseExit()
    {
        rend.material.color = startColor; 

    }
}
