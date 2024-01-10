using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasCamera : MonoBehaviour
{
    [SerializeField] GameObject[] players;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        players = GameObject.FindGameObjectsWithTag("Player");


        for (int i = 0; i < players.Length; i++)
        {
            if (players[i].GetComponent<TowerPlacement>().playerID == 2)
            {
                gameObject.GetComponent<Canvas>().worldCamera = players[i].transform.GetChild(0).gameObject.GetComponent<Camera>();
            }
            if(i >= players.Length)
            {
                i = 0;
            }
        }
        
    }




}
