using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class KeyPickup : MonoBehaviour
{
    public int keyPickups = 0;
    public int maxKeyPickups = 3;
    private bool is_destroyed = false;

    public Text keyText;





    private void OnTriggerEnter(Collider otherObject)
    {

        if (otherObject.transform.tag == "Player")
        {
            LocalManager.Instance.keyPickups++;
            keyText.text = "Keys: " + LocalManager.Instance.keyPickups.ToString() + "/" + LocalManager.Instance.maxKeyPickups.ToString();
            Destroy(gameObject);

        }
    }




}
