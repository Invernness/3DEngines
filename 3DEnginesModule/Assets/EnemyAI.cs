using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Coherence.Toolkit;

public class EnemyAI : MonoBehaviour
{
    float speed = 1f;

    float damage = 10;

    public float Health;

    bool isDead = false;
    public CoherenceSync sync;


    [SerializeField] CurrencyManager currencyManagement;

    private void Start()
    {
        currencyManagement = GameObject.FindGameObjectWithTag("Currency").GetComponent<CurrencyManager>();
        currencyManagement.Enemy();
        sync = gameObject.GetComponentInParent<CoherenceSync>();
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = Vector3.MoveTowards(transform.position, new Vector3(0, 0, 0), speed * Time.deltaTime);

        //GetComponent<CoherenceSync>().SendCommand<EnemyAI>("Move", Coherence.MessageTarget.All);
        Move();

    }

    public void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(0, 0, 0), speed * Time.deltaTime);
    }


    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "Base")
        {
            print("hit base");
            collision.gameObject.GetComponent<Health>().TakeDamage(damage);
            GetComponent<MeshRenderer>().enabled = false;
            GetComponent<BoxCollider>().enabled = false;
            transform.position = new Vector3(10000, 10000, 10000);
            GetComponent<EnemyAI>().enabled = false;
        }


    }


    public void DamageEnemies(float dmg)
    {
        Health = Health - dmg;

        if(Health <= 0 && isDead == false)
        {
            //Destroy(this.gameObject);
            GetComponent<MeshRenderer>().enabled = false;
            GetComponent<BoxCollider>().enabled = false;
            transform.position = new Vector3(10000, 10000, 10000);
            currencyManagement.EnemyDied();
            isDead = true;
            GetComponent<EnemyAI>().enabled = false;
            
        }

    }


}
