using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Train6SpawnPoint : MonoBehaviour
{
    float train6Timer = 5.0f;
    public GameObject train6Prefab;


    void Update()
    {
        train6Timer -= Time.deltaTime;

        if (train6Timer <= 0)
        {
            Instantiate(train6Prefab, transform);
            train6Timer = 5f;
        }
    }
}

