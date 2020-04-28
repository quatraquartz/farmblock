using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextDay : MonoBehaviour
{

    public bool nextDay;
    private bool selected;


    private void Update()
    {
        if (selected == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                nextDay = true;
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            nextDay = false;
        }
    }

    private void OnMouseOver()
    {
        selected = true;
    }

    private void OnMouseExit()
    {
        selected = false;
    }


}
