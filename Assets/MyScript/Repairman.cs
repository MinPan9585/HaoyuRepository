using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repairman : MonoBehaviour
{
    bool followMouse = false;

    private void OnMouseDown()
    {
        followMouse = true;
    }

    private void OnMouseUp()
    {
        followMouse = false;
        //if
        //return to original position
        //else, repair
    }

    private void Update()
    {
        if(followMouse == true)
        {

        }
    }
}
