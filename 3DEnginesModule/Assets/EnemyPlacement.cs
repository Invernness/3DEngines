using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Coherence.Toolkit;

public class EnemyPlacement : MonoBehaviour
{

    [SerializeField] GameObject spawner;

    [SerializeField] CurrencyManager currencyManagement;

    // Start is called before the first frame update
    void Start()
    {
        spawner = GameObject.FindGameObjectWithTag("Spawner");

        currencyManagement = GameObject.FindGameObjectWithTag("Currency").GetComponent<CurrencyManager>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && currencyManagement.enemyCredits >= 10)
        {
            spawner.GetComponent<EnemySpawn>().UpSpawn();
            //currencyManagement.Enemy();
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) && currencyManagement.enemyCredits >= 10)
        {
            spawner.GetComponent<EnemySpawn>().DownSpawn();
            //currencyManagement.Enemy();
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) && currencyManagement.enemyCredits >= 10)
        {
            spawner.GetComponent<EnemySpawn>().RightSpawn();
            //currencyManagement.Enemy();
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) && currencyManagement.enemyCredits >= 10)
        {
            spawner.GetComponent<EnemySpawn>().LeftSpawn();
            //currencyManagement.Enemy();
        }

    }

}
