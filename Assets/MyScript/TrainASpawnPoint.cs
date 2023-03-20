using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainASpawnPoint : MonoBehaviour
{
    public float trainATimer = 1f;
    public float timeBetweenTrains = 2f;
    public GameObject trainAPrefab;

    void Update()
    {
        trainATimer -= Time.deltaTime;

        if(trainATimer <= 0)
        {
            Instantiate(trainAPrefab, transform);
            trainATimer = timeBetweenTrains;
        }
    }
}
