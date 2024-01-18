using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Coherence.Toolkit;

public class Health : MonoBehaviour
{

    public float health;
    public CoherenceSync sync;



    // Start is called before the first frame update
    void Start()
    {
        health = 100f;
        sync = gameObject.GetComponentInParent<CoherenceSync>();
    }

    private void Update()
    {
        GameObject.FindGameObjectWithTag("Canvas").transform.GetChild(2).transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>().text = health.ToString();
        //print(health);
    }

    public void TakeDamage()
    {
        //health = health - amount;

        //if(health <= 0)
        //{
        //    Death();
        //}

        //GetComponent<CoherenceSync>().SendCommand<Health>("Dmg", Coherence.MessageTarget.All);
        Dmg();
    }

    public void Dmg()
    {
        health = health - 10;

        if (health <= 0)
        {
            health = 0;
            Death();
        }
    }


    void Death()
    {
        Destroy(this.gameObject);
    }



}
