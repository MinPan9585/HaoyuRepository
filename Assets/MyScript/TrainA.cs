using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainA : MonoBehaviour
{
    Transform[] trainAWayPoints;
    public float speed;
    int index = 1;

    void Start()
    {
        trainAWayPoints = GameObject.Find("TrainAPath").GetComponentsInChildren<Transform>();
    }

    void Update()
    {
        transform.Translate((trainAWayPoints[index].position - transform.position).normalized * speed * Time.deltaTime, Space.World);

        if(Vector3.Distance(trainAWayPoints[index].position, transform.position) <= 0.2f)
        {
            if (index == trainAWayPoints.Length - 1)
            {
                Destroy(gameObject);
                //money ++;
                return;
            }
                
            index++;
        }
    }
}
