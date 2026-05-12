using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBlue : MonoBehaviour
{
    public PickUpScript script;
    public GameObject other;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (script.blue == true)
            {
                Destroy(other);
            }
        }
    }
}