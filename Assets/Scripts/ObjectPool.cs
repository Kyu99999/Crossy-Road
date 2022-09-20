using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;


public class ObjectPool<T> //: MonoBehaviour where T : MonoBehaviour
{
    public GameObject[] trees;
    public GameObject[] cars;

    public Gameobject testPrefab;

    public List<T> listPool;    
    public Queue<T> QueuePool;  
    public Dictionary<CarsName, T> dictionaryPool;    //cars, rail


    private void Awake()
    {
        listPool = new List<T>();
        QueuePool = new Queue<T>();
        dictionaryPool = new Dictionary<CarsName, T>();

        listPool.Add(Instantiate(testPrefab));

        Debug.Log(listPool[0]);
    }
   

    void Start()
    {

    }

    private void Update()
    {
        Debug.Log("Test");
    }

    public Init(Gameobject objs)
    {
        testPrefab = objs;
    }

    public Gameobject GetObj()
    {

        return testPrefab;
    }
}