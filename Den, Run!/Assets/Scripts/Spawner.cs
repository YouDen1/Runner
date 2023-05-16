using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject Enemies;

    private float TimeBtwSpawn;
    public float StartTimeBtwSpawn;
    public float DecreaseTime;
    public float MinTime;

    private void Update()
    {
        if(TimeBtwSpawn <= 0)
        {
            Instantiate(Enemies, transform.position, Quaternion.identity);
            TimeBtwSpawn = StartTimeBtwSpawn;
            if(StartTimeBtwSpawn > MinTime)
            {
                StartTimeBtwSpawn -= DecreaseTime;
            }
        }
        else
        {
            TimeBtwSpawn -= Time.deltaTime;
        }
    }
}
