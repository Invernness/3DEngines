using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerAttack : MonoBehaviour
{

    [SerializeField] GameObject closestEnemy;

    [SerializeField] GameObject[] allEnemies;

    float distance;
    float smallestDist = 1000f;

    float timer = 0;

    float TowerDamage = 100f;

    // Update is called once per frame
    void Update()
    {
        closestEnemy = GameObject.FindGameObjectWithTag("Enemy");

        distance = Vector3.Distance(gameObject.transform.position, closestEnemy.transform.position);


        //allEnemies = GameObject.FindGameObjectsWithTag("Enemy");

        //for (int i = 0; i < allEnemies.Length; i++)
        //{
        //    distance = Vector3.Distance(gameObject.transform.position, allEnemies[i].transform.position);

        //    if (distance < smallestDist)
        //    {
        //        smallestDist = distance;

        //        closestEnemy = allEnemies[i].gameObject;

        //    }

        //    if (i > allEnemies.Length)
        //    {
        //        smallestDist = 10000f;
        //        i = 0;
        //    }

        //}

        timer++;

        if(timer >= 2000 && distance < 4)
        {
            HitEnemy();
            timer = 0;
            print(distance);
        }
    }

    private void Start()
    {
        HitEnemy();
    }

    public void HitEnemy()
    {
        //if(closestEnemy != null)
        //{
        //    closestEnemy.GetComponent<EnemyAI>().DamageEnemies(TowerDamage);
        //    print("Hit Enemy");
        //}
        
        
        closestEnemy.GetComponent<EnemyAI>().DamageEnemies(TowerDamage);

        Invoke("HitEnemy", 1);
    }


}
