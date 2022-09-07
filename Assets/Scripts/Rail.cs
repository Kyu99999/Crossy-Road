using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Rails
{
    BLANKROAD,
    GRASS,
    RAILROAD,
    RIVER,
    ROAD
}


public class Rail : MonoBehaviour
{
    public Rails rail;
    
    //Test code
    public GameObject[] trees;
    public GameObject[] Cars;
    //
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Init()
    {
        switch (rail)
        {
            case Rails.BLANKROAD:
                break;
            case Rails.GRASS:
                MakeTree();
                break;
            case Rails.RAILROAD:
                break;
            case Rails.RIVER:
                break;
            case Rails.ROAD:
                break;
            default:
                break;
        }
    }
    public void MakeTree()
    {
        //Test Code
        int treeCount = Random.Range(0, 6);

        for (int i = 0; i < treeCount; i++)
        {
            Vector3 pos = new Vector3(Random.Range(-4, 5), 0, 0);
            Instantiate(trees[0], transform.position + pos, Quaternion.identity);    //Use Object Pool !!
        }
        //
    }

    public void MakeCar()
    {
        //Test Code
        
        //
    }
}
