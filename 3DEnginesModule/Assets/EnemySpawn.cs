using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    Transform upSpawn;

    [SerializeField] GameObject EnemyObj;

    // Start is called before the first frame update
    void Start()
    {
        upSpawn = GameObject.FindGameObjectWithTag("Up").transform;
    }

    public void UpSpawn()
    {
        GameObject Enemy = Instantiate(EnemyObj, upSpawn.transform.position, Quaternion.identity);
    }



}
