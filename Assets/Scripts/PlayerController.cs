using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody rb;
    public float speed;

    public Inventory inv;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
     
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("eggplant"))
        {
            Destroy(other.gameObject);
            inv.EggplantSeeds = inv.EggplantSeeds + 1;
        }

        if (other.gameObject.CompareTag("tomato"))
        {
            Destroy(other.gameObject);
            inv.TomatoSeeds = inv.TomatoSeeds + 1;
        }

        if (other.gameObject.CompareTag("pumpkin"))
        {
            Destroy(other.gameObject);
            inv.PumpkinSeeds = inv.PumpkinSeeds + 1;
        }

        if (other.gameObject.CompareTag("pea"))
        {
            Destroy(other.gameObject);
            inv.PeaSeeds = inv.PeaSeeds + 1;
        }

    }
}
