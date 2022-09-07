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

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * Time.deltaTime * speed;
    }

    public void Init(CarsName carsName)
    {
        
        this.gameObject.SetActive(false);
    }

    public void Set(Vector3 pos)
    {
        transform.position = pos;
        oriPos = pos;
        speed = Random.Range(3, 7);
        transform.rotation = Quaternion.Euler(new Vector3(0, 90, 0));
    }
}
