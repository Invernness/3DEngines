using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    public float health;

    // Start is called before the first frame update
    void Start()
    {
        health = 100f;
    }

    public void TakeDamage(float amount)
    {
        health = health - amount;

        if(health <= 0)
        {
            Death();
        }

    }

    void Death()
    {
        Destroy(this.gameObject);
    }



}
