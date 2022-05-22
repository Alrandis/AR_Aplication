using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Light_swith : MonoBehaviour
{
    public GameObject red;
    public GameObject green;
    public GameObject yellow;
    public bool color = true;

    public void SelectRed()
    {
        if (color == true)
        {
            red.GetComponent<Renderer>().material.color = new Color(1, 1, 1);
            color = false;
        }
        else if (color == false)
        {
            red.GetComponent<Renderer>().material.color = new Color(1f, 0, 0);
            color = true;
        }
    }
    public void SelectGreen()
    {
        if (color == true)
        {
            green.GetComponent<Renderer>().material.color = new Color(1, 1, 1);
            color = false;
        }
        else if (color == false)
        {
            green.GetComponent<Renderer>().material.color = new Color(1f, 0, 0);
            color = true;
        }
    }
    public void SelectYellow()
    {
        if (color == true)
        {
            yellow.GetComponent<Renderer>().material.color = new Color(1, 1, 1);
            color = false;
        }
        else if (color == false)
        {
            yellow.GetComponent<Renderer>().material.color = new Color(1f, 0, 0);
            color = true;
        }
    }
}
