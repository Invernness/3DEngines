using System.Collections;
using Coherence.Toolkit;
using System.Collections.Generic;
using UnityEngine;

public class TowerPlacement : MonoBehaviour
{
    [SerializeField] CoherenceBridge Bridge;

    [SerializeField] CoherenceSync sync;

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
        sync = this.gameObject.GetComponent<CoherenceSync>();
        Cubes = GameObject.FindGameObjectsWithTag("Cube");

        upSpawn = GameObject.FindGameObjectWithTag("Up").transform;
        canvas = GameObject.FindGameObjectWithTag("Canvas");


    }

    //private void ClientConnections_OnCreated(CoherenceClientConnection obj)
    //{
    //    isConnected = true;
    //    playerID = playerID + 1;
    //}

    // Update is called once per frame
    void Update()
    {


        if (sync.HasStateAuthority)
        {
            
            
            //canvas.transform.GetChild(0).gameObject.SetActive(true);

                //players = GameObject.FindGameObjectsWithTag("Player");

                //for (int i = 0; i < players.Length; i++)
                //{
                //    if (players[i].GetComponent<TowerPlacement>().playerID != playerID)
                //    {
                //        //players[i].gameObject.transform.GetChild(0).gameObject.SetActive(false);
                //    }
                //}




            
        }

        



        //for (int i = 0; i < Cubes.Length; i++)
        //{
        //    Cubes[i].GetComponent<Cube>().SpawnTower();
        //    if (i >= Cubes.Length)
        //    {
        //        i = 0;
        //    }
        //}


    }




}
