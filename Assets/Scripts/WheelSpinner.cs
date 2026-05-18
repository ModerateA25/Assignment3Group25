using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelSpinner : MonoBehaviour
{

    public float speed;



    //158 - 203

    // Start is called before the first frame update
    void Start()
    {
        speed = 1200;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(0, speed * Time.deltaTime, 0);
        speed -= 1;

        if(speed <= 0)
        {

            speed = 1200;
        }
    }

}
