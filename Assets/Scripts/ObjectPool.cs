using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;


public class ObjectPool: MonoBehaviour 
{
    public GameObject[] trees;
    public GameObject[] cars;

    public GameObject testPrefab;

    //public List<T> listPool;
    public Queue<GameObject> queuePool;
    //public Dictionary<CarsName, T> dictionaryPool;    //cars, rail


    private void Awake()
    {
    }


    void Start()
    {

    }

    private void Update()
    {
    }

    // parent�� �θ�� ��ü�� ���� ���� ����.
    public void Init(GameObject objs, GameObject parent)
    {
        queuePool = new Queue<GameObject>();
        for (int i = 0; i < 3; i++)
        {
            GameObject gameObj = Instantiate(objs, parent.transform);
           
            gameObj.SetActive(false);

            queuePool.Enqueue(gameObj);
        }
    }

    // ���ο� obj �߰�
    public void AddPool(GameObject obj, GameObject parent)
    {
        GameObject gameObj = Instantiate(obj, parent.transform);
        gameObj.SetActive(false);
        queuePool.Enqueue(gameObj);
    }

    // �ݳ�
    public void InsertObj(GameObject obj)
    {
        obj.SetActive(false);

        queuePool.Enqueue(obj);
    }

    
    public GameObject GetObj()
    {
        GameObject gameObj = queuePool.Dequeue();
        gameObj.SetActive(true);
        return gameObj;
    }
}