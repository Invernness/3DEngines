using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Coherence.Toolkit;

public class Cube : MonoBehaviour
{

    [SerializeField] GameObject TowerObj;

    public Material red;
    public Material white;
    public Material blue;

    bool isClicked = false;

    //[SerializeField] GameObject[] player;

    //[SerializeField] TowerPlacement towerPlayer;

    //private void Update()
    //{
    //    player = GameObject.FindGameObjectsWithTag("Player");

    //    foreach (GameObject go in player)
    //    {
    //        if(go.GetComponentInChildren<TowerPlacement>() == enabled)
    //        {
    //            towerPlayer = go.GetComponentInChildren<TowerPlacement>();
    //        }

    //    }

    //}


    public void OnHit()
    {
        if (GetComponent<MeshRenderer>().material != red)
        {
            GetComponent<MeshRenderer>().material = red;
            isClicked = true;
        }
        else
        {
            GetComponent<MeshRenderer>().material = white;
            isClicked = false;
        }




    }

    public void OnHover()
    {
        if (gameObject.GetComponent<MeshRenderer>().material != red)
        {
            GetComponent<MeshRenderer>().material = blue;
        }


    }
    public void NonHover()
    {
        if (!isClicked)
        {
            GetComponent<MeshRenderer>().material = white;
        }
    }
    
    public void SpawnTower()
    {
        
        if (isClicked)
        {
            print("Tower Spawned");
            GameObject Tower = Instantiate(TowerObj, gameObject.transform.position, gameObject.transform.rotation);
            isClicked = false;
        }
    }
    

    public void OnMouseDown()
    {
        
        GetComponent<CoherenceSync>().SendCommand<Cube>("OnHit", Coherence.MessageTarget.All);
    }

    private void OnMouseEnter()
    {
        GetComponent<CoherenceSync>().SendCommand<Cube>("OnHover", Coherence.MessageTarget.All);
    }

    private void OnMouseExit()
    {
        GetComponent<CoherenceSync>().SendCommand<Cube>("NonHover", Coherence.MessageTarget.All);
    }

}
