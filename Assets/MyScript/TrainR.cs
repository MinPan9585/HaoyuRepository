using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainR : MonoBehaviour
{
    Transform[] trainRWayPoints;
    public float speed;
    int index = 1;

    void Start()
    {
        trainRWayPoints = GameObject.Find("TrainRPath").GetComponentsInChildren<Transform>();
    }

    void Update()
    {
        transform.Translate((trainRWayPoints[index].position - transform.position).normalized * speed * Time.deltaTime, Space.World);

        if (Vector3.Distance(trainRWayPoints[index].position, transform.position) <= 0.2f)
        {
            if (index == trainRWayPoints.Length - 1)
            {
                Destroy(gameObject);
                //money ++;
                return;
            }

            index++;
        }
    }
}
