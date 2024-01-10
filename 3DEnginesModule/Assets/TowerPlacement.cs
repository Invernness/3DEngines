using System.Collections;
using Coherence.Toolkit;
using System.Collections.Generic;
using UnityEngine;

public class TowerPlacement : MonoBehaviour
{
    [SerializeField] CoherenceBridge Bridge;

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
        Bridge = GameObject.FindGameObjectWithTag("Bridge").GetComponent<CoherenceBridge>();
        Bridge.ClientConnections.OnCreated += ClientConnections_OnCreated;

        Cubes = GameObject.FindGameObjectsWithTag("Cube");

        upSpawn = GameObject.FindGameObjectWithTag("Up").transform;
        canvas = GameObject.FindGameObjectWithTag("Canvas");


    }

    private void ClientConnections_OnCreated(CoherenceClientConnection obj)
    {
        isConnected = true;
        playerID = playerID + 1;
    }

    // Update is called once per frame
    void Update()
    {
        //if (playerID == 1)
        //{
        //    if (Input.GetMouseButtonDown(0))
        //    {
        //        //Instantiate Cylinder Ontop of Cube Clicked
        //        for (int i = 0; i < Cubes.Length; i++)
        //        {
        //            Cubes[i].GetComponent<Cube>().SpawnTower();
        //        }

        //    }
        //}
        if (playerID == 1)
        {
            //if (Input.GetKeyDown(KeyCode.UpArrow))
            //{
            //    //Instantiate Cube at Pathway Entrances
            //    GameObject Enemy = Instantiate(EnemyObj, upSpawn.transform.position, Quaternion.identity);
            //}

        }

        if(playerID == 2)
        {
            canvas.transform.GetChild(0).gameObject.SetActive(true);

            players = GameObject.FindGameObjectsWithTag("Player");

            for (int i = 0; i < players.Length; i++)
            {
                if(players[i].GetComponent<TowerPlacement>().playerID != playerID)
                {
                    players[i].gameObject.transform.GetChild(0).gameObject.SetActive(false);
                }
            }

            gameObject.transform.GetChild(0).GetComponent<Camera>().cullingMask = lM;


        }


        //Instantiate Cylinder Ontop of Cube Clicked
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
