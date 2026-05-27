using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class UpdatingDoorScript : MonoBehaviour
{

    private Animation animation;

    // Start is called before the first frame update
    void Start()
    {
        animation = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("f"))
        {
            if ((LocalManager.Instance.keyPickups == LocalManager.Instance.maxKeyPickups))
            {
                animation.Play();
            }
        }
       
    }
}
