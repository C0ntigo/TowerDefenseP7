using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
     
    public TowerPlan RST;
    public TowerPlan FST;
    public TowerPlan IRT;
    public TowerPlan LRT;
    public TowerPlan PRT;

    BuildManager BM;

     void Start()
    {
        BM = BuildManager.instance;    
    }
    public void PurchaseStandardTower ()
    {
        Debug.Log("Tommy Has been Purchased");
    }
    public void FireRaccoon ()
    {
        Debug.Log("Rocky has been Purchased");
    }
}
