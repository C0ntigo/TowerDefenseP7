using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnionDMG : MonoBehaviour
{
    public int damage = 25;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Hurting>())
        {
            collision.gameObject.GetComponent<Hurting>().health -= damage;
        }
    }
}
