using System.Collections;
using Coherence.Toolkit;
using System.Collections.Generic;
using UnityEngine;

public class TowerPlacement : MonoBehaviour
{

    [SerializeField] Material white;
    [SerializeField] Material red;


    [SerializeField] CoherenceBridge Bridge;

    bool isConnected = false;

    // Start is called before the first frame update
    void Awake()
    {
        Bridge.ClientConnections.OnCreated += ClientConnections_OnCreated;
    }

    private void ClientConnections_OnCreated(CoherenceClientConnection obj)
    {
        isConnected = true;
    }

    // Update is called once per frame
    void Update()
    {
        /*
        
        if (Input.GetMouseButtonDown(0) && isConnected)
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit hit;
            Physics.Raycast(mousePos, Camera.main.transform.forward, out hit, Mathf.Infinity);



            hit.collider.gameObject.GetComponent<CoherenceSync>().SendCommand<Cube>("OnHit", Coherence.MessageTarget.All);

         //   hit.collider.gameObject.GetComponent<Cube>().OnHit();

               
        }
        

        */
    }




}
