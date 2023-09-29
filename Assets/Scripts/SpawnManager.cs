using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject cow;

    void Start()
    {
        InvokeRepeating("SpawnRandom", 1f, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
        
           
    }
    void SpawnRandom()
    {
        Instantiate(cow, new Vector3(Random.Range(-15, 15), 0, 25), cow.transform.rotation);
        Instantiate(cow, new Vector3(-22, 0, Random.Range(-3, 25)), Quaternion.Euler(new Vector3(0,90,0)));
        Instantiate(cow, new Vector3(22, 0, Random.Range(-3, 25)), Quaternion.Euler(new Vector3 (0,-90,0)));
    }
}
