using System.Collections;
using System.Collections.Generic;
using Unity.Android.Types;
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

    public Collider collider;
    private bool isStepped;

    public Transform[] startZones;
    private int zoneNum;

    //Test code
    public GameObject[] trees;
    public GameObject[] Cars;
    //

    private void Awake()
    {
        collider = GetComponent<Collider>();
        isStepped = false;
    }

    // 활성화 될 때 
    private void OnEnable()
    {
        isStepped = false;
    }

    public void Init(int num)
    {
        transform.position = new Vector3(0, 0, num);
        switch (rail)
        {
            case Rails.BLANKROAD:
                zoneNum = Random.Range(0, 2);
                StartCoroutine(SetCar());
                //자동차 생성?
                break;
            case Rails.GRASS:
                break;
            case Rails.RAILROAD:
                break;
            case Rails.RIVER:
                break;
            case Rails.ROAD:
                zoneNum = Random.Range(0, 2);
                StartCoroutine(SetCar());
                //자동차 생성?
                break;
            default:
                break;
        }
    }


    public IEnumerator SetCar()
    {
        while (true)
        {
            Car car = ObjectPoolManager.instance.carPool.GetObj().GetComponent<Car>();
            car.Set(startZones[zoneNum]);

            yield return new WaitForSeconds(2.0f);
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

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player" && !isStepped)
        {
            isStepped = true;
            // 점수업
            Gamemanager.instance.AddScore(1);
        }
    }

    private void Update()
    {
        //Test code
        Debug.Log(isStepped);
    }

}
