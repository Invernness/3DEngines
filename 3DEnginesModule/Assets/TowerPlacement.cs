using System.Collections;
using Coherence.Toolkit;
using System.Collections.Generic;
using UnityEngine;

public class TowerPlacement : MonoBehaviour
{
    [SerializeField] CoherenceBridge Bridge;

    bool isConnected = false;

    public int playerID = 0;




    // Start is called before the first frame update
    void Awake()
    {
        Bridge = GameObject.FindGameObjectWithTag("Bridge").GetComponent<CoherenceBridge>();
        Bridge.ClientConnections.OnCreated += ClientConnections_OnCreated;
    }

    private void ClientConnections_OnCreated(CoherenceClientConnection obj)
    {
        isConnected = true;
        playerID = playerID + 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(playerID == 1)
        {
            if (Input.GetMouseButtonDown(0))
            {
                //Instantiate Cylinder Ontop of Cube Clicked
            }
        }
        if (playerID == 2)
        {
            if (Input.GetMouseButtonDown(1))
            {
                //Instantiate Cube at Pathway Entrances
            }
        }

    }




}
