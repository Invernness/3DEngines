using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] Transform upSpawn;
    [SerializeField] Transform downSpawn;
    [SerializeField] Transform leftSpawn;
    [SerializeField] Transform rightSpawn;
    [SerializeField] GameObject EnemyObj;

    // Start is called before the first frame update
    void Start()
    {
        upSpawn = GameObject.FindGameObjectWithTag("Up").transform;
        downSpawn = GameObject.FindGameObjectWithTag("Down").transform;
        leftSpawn = GameObject.FindGameObjectWithTag("Left").transform;
        rightSpawn = GameObject.FindGameObjectWithTag("Right").transform;
    }

    public void UpSpawn()
    {
        GameObject Enemy = Instantiate(EnemyObj, upSpawn.transform.position, Quaternion.identity);
    }
    public void DownSpawn()
    {
        GameObject Enemy = Instantiate(EnemyObj, downSpawn.transform.position, Quaternion.identity);
    }
    public void LeftSpawn()
    {
        GameObject Enemy = Instantiate(EnemyObj, leftSpawn.transform.position, Quaternion.identity);
    }
    public void RightSpawn()
    {
        GameObject Enemy = Instantiate(EnemyObj, rightSpawn.transform.position, Quaternion.identity);
    }


}
