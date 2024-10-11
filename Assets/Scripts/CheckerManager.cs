using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckerManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private PlayerController playerController;

    void OnCollisionEnter(Collision collision) 
    {
        if (collision.gameObject.tag == "Panel")
        {
            //playerController.collided = true;
        }
    }
    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Panel")
        {
            playerController.collided = false;
        }
    }
}
