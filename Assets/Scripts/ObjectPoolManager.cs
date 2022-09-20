using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using UnityEngine;

public class ObjectPoolManager : MonoBehaviour 
{
    public static ObjectPoolManager instance;

    public ObjectPool carPool;
    public ObjectPool railPool;

    public GameObject[] carPrefabs;

    public GameObject[] railPrefabs;
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    void Start()
    {
        // Car Pool
        carPool = new ObjectPool();
        carPool.Init(carPrefabs[1], this.gameObject);
        for (int i = 0; i < 35; i++)
        {
            int num = Random.Range(0, carPrefabs.Length);
            carPool.AddPool(carPrefabs[num], this.gameObject);
        }

        // Rail Pool
        railPool = new ObjectPool();
        railPool.Init(railPrefabs[1], this.gameObject);
        for(int i = 0; i < 15; i++)
        {
            int num = Random.Range(0, railPrefabs.Length);
            railPool.AddPool(railPrefabs[num], this.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
