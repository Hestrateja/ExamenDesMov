using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] float minX,maxX,y,timeBetween,range;
    [SerializeField] GameObject good, bad;
    private float timer;


    // Update is called once per frame
    void Update()
    {
        if(timer<=0)
        {
            Instantiate(Random.Range(0, 2) < 1 ? good : bad, new Vector3(Random.Range(minX, maxX), y, 0), Quaternion.identity);
            timer = timeBetween + Random.Range(-range, range);
        }
        timer -= Time.deltaTime;
    }
}
