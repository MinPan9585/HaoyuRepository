using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccidentManager : MonoBehaviour
{
    public Accidents[] accidents;
    float accidentTimer;
    int index = 0;
    public GameObject accident1Sprite;
    public GameObject accident2Sprite;
    public GameObject accident3Sprite;

    private void Start()
    {
        accidentTimer = accidents[index].accidentTime;
    }

    void Update()
    {
        accidentTimer -= Time.deltaTime;
        if(accidentTimer <= 0)
        {
            if(accidents[index].AccidentType == 0)
            {
                PlayAccident1();
            }
            else if(accidents[index].AccidentType == 1)
            {
                PlayAccident2();
            }
            else
            {
                PlayAccident3();
            }
            //train stops
            index++;
            accidentTimer = accidents[index].accidentTime;
        }
    }

    public void PlayAccident1()
    {
        //spawn accident sprites
        GameObject train1 = GameObject.FindGameObjectWithTag("Train1");
        Instantiate(accident1Sprite, train1.transform.position, Quaternion.identity);
        train1.GetComponent<TrainA>().speed = 0;
    }

    public void PlayAccident2()
    {

    }
    public void PlayAccident3()
    {

    }
}
