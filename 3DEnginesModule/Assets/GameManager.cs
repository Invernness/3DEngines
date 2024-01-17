using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Coherence.Toolkit;

public class GameManager : MonoBehaviour
{

    [SerializeField] CoherenceBridge Bridge;
    GameObject player;
    [SerializeField] GameObject currencyObject;


    int playerPointer = 0;

    // Start is called before the first frame update
    void Start()
    {
        Bridge = GameObject.FindGameObjectWithTag("Bridge").GetComponent<CoherenceBridge>();
        Bridge.ClientConnections.OnCreated += ClientConnections_OnCreated;
    }

    private void ClientConnections_OnCreated(CoherenceClientConnection obj)
    {

        CoherenceClientConnection selectedConnection = Bridge.ClientConnections.Get(obj.ClientId);

        player = selectedConnection.GameObject;

        if(playerPointer == 0)
        {
            player.transform.GetChild(0).gameObject.SetActive(true);
        }
        if (playerPointer == 1)
        {
            player.transform.GetChild(1).gameObject.SetActive(true);
            currencyObject.GetComponent<CurrencyManager>().enabled = true;
        }

        playerPointer++;
    }





}
