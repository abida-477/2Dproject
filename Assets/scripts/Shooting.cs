using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject shootingItem; // The prefab to instantiate when shooting.
    public Transform shootingPoint; // The point from which the bullet is shot.
    public bool canShoot = true; // Determines if the player can shoot.

    private bool hasEnteredTrigger = false; // To track if the object has entered the trigger zone.

    void Update()
    {
        // Debug log to check if the update loop is running.
        Debug.Log("Update loop running");

        // Check if Return key is pressed and if the trigger zone has been entered.
        if (Input.GetKeyDown(KeyCode.Return) && hasEnteredTrigger)
        {
            Debug.Log("Shoot key pressed");
            Shoot();
        }
    }

    // Called when this object enters a trigger collider.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Debug log to check when collision occurs.
        Debug.Log("OnTriggerEnter2D called");

        if (collision.CompareTag("Player"))
        {
            hasEnteredTrigger = true; // Mark the trigger as entered.
            Debug.Log("Player entered trigger zone");
        }
    }

    // Shooting logic.
    void Shoot()
    {
        // Debug log to check if Shoot() is being called.
        Debug.Log("Shoot method called");

        if (!canShoot) // If shooting is disabled, exit the method.
            return;

        // Instantiate the shooting item at the shooting point's position and rotation.
        GameObject si = Instantiate(shootingItem, shootingPoint.position, shootingPoint.rotation);
        
        // Detach the instantiated object from its parent.
        si.transform.parent = null;
    }
}
