using Pattern.Visitor;
using System;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public PowerUp powerup;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<BikeController>())
        {
            other.GetComponent<BikeController>().Accept(powerup);
            Destroy(gameObject);
        }
    }
}