using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ObjectPool<T> : MonoBehaviour
{
    public ObjectPool<T> objectPool = null;

    public GameObject[] trees;
    public GameObject[] cars;

    public List<T> pool;

    //public Queue<GameObject> QueueTrees; //³ª¹«´Â ·£´ý
    
    //public Queue<GameObject> QueueBlueCar;
    //public Queue<GameObject> QueueBlueTruck;
    //public Queue<GameObject> QueueGreenCar;
    //public Queue<GameObject> QueueOrangeCar;
    //public Queue<GameObject> QueuePoliceCar;
    //public Queue<GameObject> QueuePurpleCar;
    //public Queue<GameObject> QueueRedTruck;
    //public Queue<GameObject> QueueTaxi;

    private void Awake()
    {
        
    }

    void Start()
    {
        pool = new List<T>();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            foreach(var i in pool)
            {
                Debug.Log(i);
            }
        }
            
    }

}
