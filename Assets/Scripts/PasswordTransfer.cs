using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(CharacterController))]

public class NewBehaviourScript : MonoBehaviour
{
    public string password;
    public GameObject input;
    public GameObject e2door;
    CharacterController characterController;


    
    public void StorePassword()
    {
        password = input.GetComponent<Text>().text;

        if (password == "3796")
        {
            Destroy(e2door);
        }
        else 
        {
            password = "Incorrect Password";
        }
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            input.SetActive(true);
        }
    }
    void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            input.SetActive(false);
        }
    }


}
