using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletV3 : MonoBehaviour
{
    public float speed = 20f;
    public int damage = 2;
    public Rigidbody2D rb;
    public float homingRadius = 10f;
    public float rotateSpeed = 200f;
    private Transform target;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        FindTarget();
    }

    void FindTarget()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
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
        if (nearestEnemy != null && shortestDistance <= homingRadius)
        {
            target = nearestEnemy.transform;
        }
    }
     void Update()
    {
        if (target == null)
        {
            FindTarget();
            return;
        }
        Vector2 direction = (Vector2)target.position - rb.position;
        direction.Normalize();
        float rotateAmount = Vector3.Cross(direction, transform.right).z;
        rb.angularVelocity = -rotateAmount * rotateSpeed;
        rb.velocity = transform.right * speed;
    }


     void OnTriggerEnter2D(Collider2D collision)
    {
        Enemy enemy = collision.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
            Destroy(gameObject);
        }
    }
}
