using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public float speed = 3f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * Time.deltaTime * speed;
    }

    public void Init()
    {
        speed = Random.Range(3, 7);
        transform.rotation = Quaternion.Euler(new Vector3(0, 90, 0));
    }
}
