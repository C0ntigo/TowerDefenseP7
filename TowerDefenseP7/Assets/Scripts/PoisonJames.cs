using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoisonJames : MonoBehaviour
{
    public int damage = 1;
    public float speed = 5f;
    public float range = 10f;
    private Vector2 startPosition;
    private Transform target;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;

        target = GameObject.FindGameObjectWithTag("Enemy").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {
            Vector2 direction = (Vector2)target.position - (Vector2)transform.position;
            direction.Normalize();
            transform.Translate(direction * speed * Time.deltaTime);

            if (Vector2.Distance(startPosition, transform.position) < range)
            {
                Destroy(gameObject);
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            collision.gameObject.GetComponent<Enemy>().TakeDamage(damage);
            Destroy(gameObject);
        }
        
            
        
    }
}
