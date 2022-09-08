using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ObjectPool<T> : MonoBehaviour where T : MonoBehaviour
{
    public GameObject[] trees;
    public GameObject[] cars;

    public T testPrefab;

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

    //public T GetListPool(GameObject obj)        
    //{
    //    if(listPool.Count == 0)
    //    {

    //        GameObject getObj = Instantiate(obj);
    //        return getObj.GetComponent<T>();
    //    }
    //    else
    //    {
    //        int lastIndex = listPool.Count - 1;
    //        T getObj = listPool[lastIndex];
    //        listPool.RemoveAt(lastIndex);
    //        return getObj;
    //    }
    //}

    //public T GetDictionaryPool(string str, GameObject obj)
    //{
    //    if (!dictionaryPool.ContainsKey(str))
    //    {
    //        GameObject getObj = Instantiate(obj);
    //        return getObj.GetComponent<T>();
    //    }
    //    else
    //    {
    //        var enumerator = dictionaryPool.GetEnumerator();
    //        while (true)
    //        {
    //            if(enumerator.Current.Key == str)
    //            {

    //            }

    //        }


    //    }
    //}

}
