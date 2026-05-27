using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeDamage : MonoBehaviour
{
    private Vector3 spawnPosition = new Vector3((float)0.82, (float)0.05, (float)151.94);



    private void OnControllerColliderHit(ControllerColliderHit hit)
    {

       
        if (hit.collider.CompareTag("Spike"))
        {

            transform.position = spawnPosition;

        }

    }

  
}
