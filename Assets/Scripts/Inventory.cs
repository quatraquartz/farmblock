using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public int EggplantSeeds;
    public int PumpkinSeeds;
    public int TomatoSeeds;
    public int PeaSeeds;

    public int Eggplant;
    public int Pumpkin;
    public int Tomato;
    public int Pea;

    public Text inventoryText;

    void Start()
    {
        EggplantSeeds = 0;
        PumpkinSeeds = 0;
        TomatoSeeds = 0;
        PeaSeeds = 0;

        Eggplant = 0;
        Pumpkin = 0;
        Tomato = 0;
        Pea = 0;
        
    }

    private void Update()
    {
        inventoryText.text = "Inventory" + "\n"
        + "eggplant seeds: " + EggplantSeeds.ToString() + "\n"
        + "pumpkin seeds: " + PumpkinSeeds.ToString() + "\n"
        + "tomato seeds: " + TomatoSeeds.ToString() + "\n"
        + "pea seeds: " + PeaSeeds.ToString() + "\n"
        + "eggplants: " + Eggplant.ToString() + "\n"
        + "pumpkins: " + Pumpkin.ToString() + "\n"
        + "tomatoes: " + Tomato.ToString() + "\n"
        + "peas: " + Pea.ToString();

    }


}
