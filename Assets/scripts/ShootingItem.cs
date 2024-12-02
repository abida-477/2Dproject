using System.Collections;
using System.Collections.Generic;
﻿using UnityEngine;
public class ShootingItem : MonoBehaviour
{
    public float speed;

    private void Update()
    {
        transform.Translate(transform.right * transform.localScale.x * speed * Time.deltaTime);  // Translates the object along its right direction (local x-axis) multiplied by its scale, speed, and time.

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")  
            return;

        //Trigger the custom action on the other object IF IT EXISTS
        if (collision.GetComponent<ShootingAction>())
        {
            collision.GetComponent<ShootingAction>().Action();
        }
        //Destroy
        Destroy(gameObject);

    }
    }
