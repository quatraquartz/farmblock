using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCamera : MonoBehaviour
{

    public GameObject target;
    
    void Update()
    {
        this.transform.LookAt( target.transform);

    }
 
}
