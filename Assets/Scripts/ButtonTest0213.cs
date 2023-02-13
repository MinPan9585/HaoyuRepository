using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTest0213 : MonoBehaviour
{
    public GameObject panel1;
    public GameObject panel2;
    public void HideText()
    {
        panel1.SetActive(false);
        panel2.SetActive(true);
    }
}
