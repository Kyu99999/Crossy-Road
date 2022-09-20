using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CarsName
{   
    BLUECAR = 0,
    BLUETRUCK,
    GREENCAR,
    ORANGECAR,
    POLICECAR,
    PURPLECAR,
    REDTRUCK,
    TAXI
}


public class Car : MonoBehaviour
{
    public CarsName name;
    public float speed = 3f;

    public Vector3 oriPos;
    private float timer = 0f;
    private float maxTime = 6f;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * Time.deltaTime * speed;

        timer += Time.deltaTime;
        if(timer > maxTime)
        {
            timer = 0f;
            ObjectPoolManager.instance.carPool.InsertObj(this.gameObject);
        }
    }

    public void Init(CarsName carsName)
    {
        this.gameObject.SetActive(false);
    }

    public void Set(Transform trans)
    {
        transform.position = trans.position;
        //oriPos = pos;
        speed = Random.Range(3, 7);
        transform.rotation = trans.rotation;
    }
}
