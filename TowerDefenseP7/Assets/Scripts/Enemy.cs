using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 5.0f;
    private Transform Target;
    private int philindex;

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
        if (philindex >= Makers.Phil.Length - 1)
        {
            Destroy(gameObject);
            return;
        }
        philindex++;
        Target = Makers.Phil[philindex];
    }
}
