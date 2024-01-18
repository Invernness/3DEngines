using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Coherence.Toolkit;

public class CurrencyManager : MonoBehaviour
{

    public int towerCredits;

    public int enemyCredits;

    float timer;

    GameObject towerText;

    GameObject enemyText;

    private void Start()
    {
        towerCredits = 10;
        enemyCredits = 20;
        timer = 0.2f;
        towerText = GameObject.FindGameObjectWithTag("Canvas").transform.GetChild(1).gameObject.transform.GetChild(0).gameObject;
        enemyText = GameObject.FindGameObjectWithTag("Canvas").transform.GetChild(0).gameObject.transform.GetChild(0).gameObject;
        Invoke("AddCredits", 1);
    }

    void AddCredits()
    {
        enemyCredits = enemyCredits + 1;
        Invoke("AddCredits", timer);
    }

    private void FixedUpdate()
    {
        towerText.GetComponent<TextMeshProUGUI>().text = towerCredits.ToString();
        enemyText.GetComponent<TextMeshProUGUI>().text = enemyCredits.ToString();
        timer = timer - 0.0001f;
        

        if(timer < 0.2f)
        {
            timer = 0.2f;
        }

    }


    public void Tower()
    {
        towerCredits = towerCredits - 10;
    }



    public void Enemy()
    {
        enemyCredits = enemyCredits - 10;
    }




    public void EnemyDied()
    {
        towerCredits = towerCredits + 5;
    }



}
