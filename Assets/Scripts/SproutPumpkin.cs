using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SproutPumpkin : MonoBehaviour
{

    private bool selected;
    public GameObject sprout;
    public full full;
    public Inventory inv;



    void Update()
    {

        if (selected == true)
        {
            if (Input.GetMouseButtonUp(0))
            {

                sprout.SetActive(true);

                full.alreadyFull = true;

                inv.PumpkinSeeds = inv.PumpkinSeeds - 1;

                selected = false;

            }
        }


    }



    private void OnMouseExit()
    {
        selected = false;
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButton(0))
        {
            selected = true;

        }
    }

}
