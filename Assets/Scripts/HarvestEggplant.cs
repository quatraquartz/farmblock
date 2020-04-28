using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HarvestEggplant : MonoBehaviour
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
                inv.Eggplant = inv.Eggplant + 1;

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
