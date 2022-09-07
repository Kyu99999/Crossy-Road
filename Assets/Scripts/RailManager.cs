using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RailManager : MonoBehaviour
{
    public GameObject[] rails;
    public int count { get; set; } = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {   
            //Test Code
            GameObject rail = Instantiate(rails[(int)Random.Range(0, 4)], new Vector3(0,0,count++), Quaternion.identity);
            rail.GetComponent<Rail>().Init();
        }
    }
}
