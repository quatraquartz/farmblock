using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotEnoughSeed : MonoBehaviour
{

    public GameObject eggplanticon;
    public GameObject pumpkinicon;
    public GameObject tomatoicon;
    public GameObject peaicon;

    public Inventory inv;

    void Update()
    {

        if (inv.EggplantSeeds <= 0)
        {
            eggplanticon.SetActive(false);
        }

        if (inv.EggplantSeeds > 0)
        {
            eggplanticon.SetActive(true);
        }


        if (inv.PumpkinSeeds <= 0)
        {
            pumpkinicon.SetActive(false);
        }

        if (inv.PumpkinSeeds > 0)
        {
            pumpkinicon.SetActive(true);
        }


        if (inv.TomatoSeeds <= 0)
        {
            tomatoicon.SetActive(false);
        }

        if (inv.TomatoSeeds > 0)
        {
            tomatoicon.SetActive(true);
        }


        if (inv.PeaSeeds <= 0)
        {
            peaicon.SetActive(false);
        }

        if (inv.PeaSeeds > 0)
        {
            peaicon.SetActive(true);
        }

    }
}
