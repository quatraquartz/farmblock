using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HarvestTomato : MonoBehaviour
{

    public Inventory inv;
    public full full;
    private bool selected = false;


    void Update()
    {

        if (selected == true)
        {

            if (Input.GetMouseButtonDown(0))
            {
                inv.Tomato = inv.Tomato + 1;

                full.alreadyFull = false;

                selected = false;

                gameObject.active = false;

            }

        }


    }

    private void OnMouseEnter()
    {
        selected = true;
    }

    private void OnMouseExit()
    {
        selected = false;
    }
}
