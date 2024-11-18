using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal.Profiling.Memory.Experimental.FileFormat;
using UnityEngine;

public class Enemy : MonoBehaviour
{
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
        Playerlives.Lives--;
    }
    private void SetDamageBasedOnType()
    {
        switch (enemyType)
        {
            case EnemyType.Weak:
                damage = 10; // Weak enemy damage
                break;
            case EnemyType.Strong:
                damage = 50; // Strong enemy damage
                break;
            case EnemyType.Boss:
                damage = 100; // Boss enemy damage
                break;
            default:
                damage = 25; // Default damage for unassigned types
                break;
        }
    }

}
