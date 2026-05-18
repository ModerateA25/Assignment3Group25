using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CubeSpin : MonoBehaviour
{

    private float x;
    private float y;
    private float z;

    private void Start()
    {
        x = Random.Range(-15, 15);
        y = Random.Range(-15, 15);
        z = Random.Range(-15, 15);
    }

    void Update()
    {
        gameObject.transform.Rotate(x * Time.deltaTime , y * Time.deltaTime, z * Time.deltaTime);
    }
}
