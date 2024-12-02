using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ShootingAction : MonoBehaviour
{
    public UnityEvent action; // A UnityEvent that can be set up in the Unity Inspector to trigger custom actions.

    public void Action() // Method to invoke the UnityEvent.
    {
        action?.Invoke(); // Invokes the 'action' UnityEvent if it is not null.
    }
}