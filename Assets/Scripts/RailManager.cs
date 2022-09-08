using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RailManager : MonoBehaviour
{
    public Rail[] rails;
    public int count { get; set; } = 1;

    public ObjectPool<Rail> railPool;
    
    void Start()
    {
        railPool = new ObjectPool<Rail>();
        Instantiate(railPool);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W)) //
        {
            Debug.Log(railPool.listPool[0]);
        }
    }
}
