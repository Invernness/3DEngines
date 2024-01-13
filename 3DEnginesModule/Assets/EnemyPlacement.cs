using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Coherence.Toolkit;

public class EnemyPlacement : MonoBehaviour
{
    [SerializeField] CoherenceSync sync;
    [SerializeField] GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {
        sync = this.gameObject.GetComponent<CoherenceSync>();
        canvas = GameObject.FindGameObjectWithTag("Canvas");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
