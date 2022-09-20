using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RailManager : MonoBehaviour
{
    public static RailManager instance;

    public Rail[] rails;
    public int count { get; set; } = 1;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    void Start()
    {
      
     }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)) //
        {
            GameObject railObj = ObjectPoolManager.instance.railPool.GetObj();
            Rail rail = railObj.GetComponent<Rail>();
            rail.Init(count++);
        }
    }
}
