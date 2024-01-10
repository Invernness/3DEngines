using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    float speed = 1f;

    [SerializeField] float damage;

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(0, 0, 0), speed * Time.deltaTime);




    }

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "Base")
        {
            collision.gameObject.GetComponent<Health>().TakeDamage(damage);
            Destroy(gameObject);
        }


    }



}
