using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal.Profiling.Memory.Experimental.FileFormat;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 3;
    public static int playerMoney = 1;
    public Rigidbody2D onionRB;
    public float speed = 5.0f;
    private Transform Target;
    public EnemyType enemyType;
    private int markerindex;
    public int damage = 25;
    // Start is called before the first frame update

   
    void Start()
    {
        Target = Makers.Phil[0];
    }

   
    // Update is called once per frame
    void Update()
    {
        Vector2 dir = Target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        if (Vector2.Distance(transform.position, Target.position) <= 0.3f)
        {
            GetNextMaker();
        }
    }
    void GetNextMaker() 
    {
        if (markerindex >= Makers.Phil.Length - 1)
        {
            EndPath();
            return;
        }
        markerindex++;
        Target = Makers.Phil[markerindex];
    }

    void EndPath()
    {
        Destroy(gameObject);
        Playerlives.Lives = Playerlives.Lives - damage;
    }
   public void TakeDamage(int damage)
    {
        health -= damage;
        if (health < 0)
        {
            Die();
            Playerlives.Money = playerMoney += 1;
        }
    }
    void Die()
    {
        Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            int damage = collision.gameObject.GetComponent<BulletV2>().damage;
            TakeDamage(damage);

            Destroy(collision.gameObject);
            
        }
    }




}
