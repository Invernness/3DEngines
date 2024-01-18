using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Health : MonoBehaviour
{

    public float health;




    // Start is called before the first frame update
    void Start()
    {
        health = 100f;
        
    }

    private void Update()
    {
        GameObject.FindGameObjectWithTag("Canvas").transform.GetChild(2).transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>().text = health.ToString();
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
