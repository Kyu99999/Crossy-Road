using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RailManager : MonoBehaviour
{
    public Rail[] rails;
    public int count { get; set; } = 1;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W)) //
        {
            Rail rail = rails[0];
            ObjectPool<Rail> railPool = new ObjectPool<Rail>();
            railPool.pool.Add(rail);
        }
    }
}
