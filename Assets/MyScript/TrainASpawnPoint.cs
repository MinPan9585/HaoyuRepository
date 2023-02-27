using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainASpawnPoint : MonoBehaviour
{
    float trainATimer = 5.0f;
    public GameObject trainAPrefab;

    
    void Update()
    {
        trainATimer -= Time.deltaTime;

        if(trainATimer <= 0)
        {
            Instantiate(trainAPrefab, transform);
            trainATimer = 5f;
        }
    }
}
