using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public static ObjectPool objectPool = null;

    public GameObject[] trees;
    public GameObject[] cars;

    public Queue<GameObject> QueueTrees;
    public Queue<GameObject> QueueCars;

    private void Awake()
    {
        if(objectPool == null)
        {
            objectPool = this;
        }
        else
        {
            if(objectPool != this)
            {
                Destroy(this.gameObject);
            }
        }
    }

    void Start()
    {
        for(int i=0; i< 100; i++)
        {
            GameObject tree = Instantiate(trees[Random.Range(0, 4)]);
            tree.SetActive(false);
            QueueTrees.Enqueue(tree);

            GameObject car = Instantiate(cars[Random.Range(0, 8)]);
            car.SetActive(false);
            QueueCars.Enqueue(car);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
