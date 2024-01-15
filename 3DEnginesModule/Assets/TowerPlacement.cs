using System.Collections;
using Coherence.Toolkit;
using System.Collections.Generic;
using UnityEngine;

public class TowerPlacement : MonoBehaviour
{
    [SerializeField] CoherenceBridge Bridge;

    public CoherenceSync sync;

    bool isConnected = false;

    public int playerID = 0;

    [SerializeField] GameObject[] Cubes;

    [SerializeField] GameObject EnemyObj;

    Transform upSpawn;

    [SerializeField] GameObject canvas;

    [SerializeField] GameObject[] players;

    public LayerMask lM;

    // Start is called before the first frame update
    void Awake()
    {
        //Bridge = GameObject.FindGameObjectWithTag("Bridge").GetComponent<CoherenceBridge>();
        //Bridge.ClientConnections.OnCreated += ClientConnections_OnCreated;
        sync = gameObject.GetComponentInParent<CoherenceSync>();
        Cubes = GameObject.FindGameObjectsWithTag("Cube");

        upSpawn = GameObject.FindGameObjectWithTag("Up").transform;
        canvas = GameObject.FindGameObjectWithTag("Canvas");


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
