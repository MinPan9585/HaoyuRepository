using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainRSpawnPoint : MonoBehaviour
{
    float trainRTimer = 5.0f;
    public GameObject trainRPrefab;


    void Update()
    {
        trainRTimer -= Time.deltaTime;

        if (trainRTimer <= 0)
        {
            Instantiate(trainRPrefab, transform);
            trainRTimer = 5f;
        }
    }
}

