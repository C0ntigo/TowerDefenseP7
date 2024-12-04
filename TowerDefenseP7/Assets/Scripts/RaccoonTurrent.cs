using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaccoonTurrent : MonoBehaviour
{
   
    public Transform target;
    public float range = 15f;

    [Header("Attributes")]
    public float fireRate = 1f;
    private float firecountdown = 0f;
    public string enemyTag = "Enemy";

    [Header("Unity Setup Fields")]

    public GameObject bulletPrefab;
    public Transform firePoint;
   // public Transform partToRotate;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("UpdateTarget", 0f, 0.5f);
    }


    void UpdateTarget () 
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag);
        float shortestDistance = Mathf.Infinity;
        GameObject nearestEnemy = null;

        foreach (GameObject enemy in enemies)
        {
            float distanceToEnemy = Vector2.Distance(transform.position, enemy.transform.position);
            if (distanceToEnemy < shortestDistance)
            {
                shortestDistance = distanceToEnemy;
                nearestEnemy = enemy;
            }
        }
        if (nearestEnemy != null && shortestDistance <= range)
        {
            target = nearestEnemy.transform;
        }
        else
        {
            target = null;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (target == null) { return; }

        Vector2 dir = target.position - transform.position;
        Quaternion lookRotation = Quaternion.LookRotation(dir);
        Vector2 rotation = lookRotation.eulerAngles;
        //partToRotate.rotation = Quaternion.Euler (0f, rotation.x, 0f);

        if (firecountdown <= 0f)
        {
            Shoot();
            firecountdown = 1f / fireRate;

        }

        firecountdown -= Time.deltaTime;

    }

    void Shoot()
    {
        
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);
    }
   
}
