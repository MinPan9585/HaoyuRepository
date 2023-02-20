using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowControl : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject panel1;
    public GameObject panel2;
    public GameObject panel3;

    public 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void panel_change()
    {
        panel1.SetActive(false);
        panel2.SetActive(true);
    }
    public void panel_close()
    {
        panel1.SetActive(false);
        int num = Random.Range(1, 4);
        if (num == 1)
        {
            panel2.SetActive(true);
        }
        if (num == 2)
        {
            panel3.SetActive(true);
        }
    }

    public void panel_open()
    {
        panel1.SetActive(true);
    }



}
