using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Coherence.Toolkit;

public class GameManager : MonoBehaviour
{

    [SerializeField] CoherenceBridge Bridge;
    [SerializeField] GameObject canvas;

    int playerPointer = 0;

    // Start is called before the first frame update
    void Awake()
    {
        Bridge = GameObject.FindGameObjectWithTag("Bridge").GetComponent<CoherenceBridge>();
        Bridge.ClientConnections.OnCreated += ClientConnections_OnCreated;

        canvas = GameObject.FindGameObjectWithTag("Canvas");
    }

    private void ClientConnections_OnCreated(CoherenceClientConnection obj)
    {
        if(playerPointer == 1)//both player's connected
        {
            
        }
        CoherenceClientConnection selectedConnection = Bridge.ClientConnections.Get(obj.ClientId);

        GameObject player = selectedConnection.GameObject;

        if(playerPointer == 0)
        {
            player.GetComponent<EnemyPlacement>().enabled = true;
        }
        if (playerPointer == 1)
        {
            player.GetComponent<TowerPlacement>().enabled = true;
        }
        //canvas.transform.GetChild(playerPointer).gameObject.SetActive(true);



        playerPointer++;
    }
}
