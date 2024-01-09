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


    // Start is called before the first frame update
    void Awake()
    {
        Bridge = GameObject.FindGameObjectWithTag("Bridge").GetComponent<CoherenceBridge>();
        Bridge.ClientConnections.OnCreated += ClientConnections_OnCreated;

        Cubes = GameObject.FindGameObjectsWithTag("Cube");
    }

    private void ClientConnections_OnCreated(CoherenceClientConnection obj)
    {
        isConnected = true;
        playerID = playerID + 1;
    }

    // Update is called once per frame
    void Update()
    {
        //if(playerID == 1)
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
        //if (playerID == 2)
        //{
        //    if (Input.GetMouseButtonDown(1))
        //    {
        //        //Instantiate Cube at Pathway Entrances
        //    }
        //}
        
        
        //Instantiate Cylinder Ontop of Cube Clicked
        for (int i = 0; i < Cubes.Length; i++)
        {
            Cubes[i].GetComponent<Cube>().SpawnTower();
            if(i >= Cubes.Length)
            {
                i = 0;
            }
        }
        
        
    }




}
