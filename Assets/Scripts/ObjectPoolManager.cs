using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPoolManager : MonoBehaviour
{
    public ObjectPool<Car> carPool;
    public Gameobject obj;

    void Start()
    {
        carPool = new ObjectPool<Car>();
        carPool
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
