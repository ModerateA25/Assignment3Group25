using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalManager : MonoBehaviour
{
   public static LocalManager Instance;

    public int keyPickups = 0;
    public int maxKeyPickups = 3;

    private void Awake()
        { Instance = this; }

}
