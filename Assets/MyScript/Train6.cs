using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Train6 : MonoBehaviour
{
    Transform[] train6WayPoints;
    public float speed;
    int index = 1;

    void Start()
    {
        train6WayPoints = GameObject.Find("Train6Path").GetComponentsInChildren<Transform>();
    }

    void Update()
    {
        transform.Translate((train6WayPoints[index].position - transform.position).normalized * speed * Time.deltaTime, Space.World);

        if (Vector3.Distance(train6WayPoints[index].position, transform.position) <= 0.2f)
        {
            if (index == train6WayPoints.Length - 1)
            {
                Destroy(gameObject);
                //money ++;
                return;
            }

            index++;
        }
    }
}
