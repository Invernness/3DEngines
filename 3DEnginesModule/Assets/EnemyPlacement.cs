using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Coherence.Toolkit;

public class EnemyPlacement : MonoBehaviour
{

    [SerializeField] GameObject spawner;
    // Start is called before the first frame update
    void Start()
    {
        spawner = GameObject.FindGameObjectWithTag("Spawner");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            spawner.GetComponent<EnemySpawn>().UpSpawn();
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            spawner.GetComponent<EnemySpawn>().DownSpawn();
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            spawner.GetComponent<EnemySpawn>().RightSpawn();
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            spawner.GetComponent<EnemySpawn>().LeftSpawn();
        }

    }

}
