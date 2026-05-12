using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyRed : MonoBehaviour
{
    public PickUpScript script;
    public GameObject other;
    
    void Update()
    {
            if (Input.GetKeyDown(KeyCode.R))

            {
                if (script.red == true)
                {
                    Destroy(other);
                }
                
            }
    }
}
