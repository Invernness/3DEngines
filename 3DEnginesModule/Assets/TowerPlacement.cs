using System.Collections;
using Coherence.Toolkit;
using System.Collections.Generic;
using UnityEngine;

public class TowerPlacement : MonoBehaviour
{


    public CoherenceSync sync;

    [SerializeField] GameObject[] Cubes;

    [SerializeField] GameObject EnemyObj;

    [SerializeField] GameObject[] players;


    // Start is called before the first frame update
    void Awake()
    {
        sync = gameObject.GetComponentInParent<CoherenceSync>();

        Cubes = GameObject.FindGameObjectsWithTag("Cube");

    }

    // Update is called once per frame
    void Update()
    {

        if (sync.HasStateAuthority)
        {
            for (int i = 0; i < Cubes.Length; i++)
            {
                Cubes[i].GetComponent<Cube>().SpawnTower();
                if (i >= Cubes.Length)
                {
                    i = 0;
                }

            }

        }

    }




}
