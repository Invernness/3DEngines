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

    bool withinDistance = false;


    // Update is called once per frame
    void Update()
    {
        //closestEnemy = GameObject.FindGameObjectWithTag("Enemy");

        //distance = Vector3.Distance(gameObject.transform.position, closestEnemy.transform.position);


        allEnemies = GameObject.FindGameObjectsWithTag("Enemy");

        

        timer += Time.deltaTime;

        if(timer >= 5)
        {
            HitEnemy();
            timer = 0;
        }

        if(Vector3.Distance(gameObject.transform.position, closestEnemy.transform.position) <= 4)
        {
            withinDistance = true;
        }
        else
        {
            withinDistance = false;
        }
        //print(Vector3.Distance(gameObject.transform.position, closestEnemy.transform.position));

    }

    private void Start()
    {
        closestEnemy = GameObject.FindGameObjectWithTag("Enemy");
    }

    public void HitEnemy()
    {
        for (int i = 0; i < allEnemies.Length; i++)
        {
            distance = Vector3.Distance(gameObject.transform.position, allEnemies[i].transform.position);

            if (distance < Vector3.Distance(gameObject.transform.position, closestEnemy.transform.position))
            {
                closestEnemy = allEnemies[i].gameObject;
            }

        }
        
        if(closestEnemy.GetComponent<EnemyAI>() != null && withinDistance)
        {
            closestEnemy.GetComponent<EnemyAI>().DamageEnemies(TowerDamage);
            print("Enemy is Hit");
        }
        
    }


}
