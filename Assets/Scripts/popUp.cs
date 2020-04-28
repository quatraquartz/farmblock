using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class popUp : MonoBehaviour
{

    public GameObject seeds;
    private bool selected = false;
    public full planted;



    void Update()
    {


        if (!planted.alreadyFull)
        {

            

            if (selected == true)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    seeds.SetActive(true);
                }
            }

            if (Input.GetMouseButtonUp(0))
            {
                Invoke("popdown", 0.05f);
            }

          

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


    private void popdown()
        {
            selected = false;
            seeds.SetActive(false);
        

        }


    }


