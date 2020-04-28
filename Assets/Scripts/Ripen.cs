using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ripen : MonoBehaviour
{

    public GameObject ripe;
    public NextDay nextmorning;


    
    void Update()
    {
        
            if (nextmorning.nextDay)
            {
                                
                ripe.SetActive(true);

                nextmorning.nextDay = false;

                gameObject.active = false;
            }       

    }



}
