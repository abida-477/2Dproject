using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if (target != null)
        {
            // Update the camera's position based on the target.
            Vector3 targetPosition = target.transform.position;
            transform.position = new Vector3(targetPosition.x, targetPosition.y, transform.position.z);
        }
        else
        {
            Debug.LogWarning("Target is null. Camera cannot follow.");
        }
       
    }
}
