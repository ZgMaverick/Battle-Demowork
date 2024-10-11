using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private GameObject checker;
    private Collider checkerCollider;
    private Vector3 tempPos;
    RaycastHit hit;
    public bool collided = true;

    // Start is called before the first frame update
    void awake()
    {
        checkerCollider = checker.GetComponent<Collider>(); 
    }
    void Start()
    {
        CheckForInnitialPosition();
    }

    void CheckForInnitialPosition()
    {
        this.transform.position = new Vector3(2, 0, 2);
    }

    void Update()
    {
        //if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out hit, Mathf.Infinity))
        if (Input.GetKeyDown("up"))
        {
            checker.transform.position = checker.transform.position + new Vector3(0, 0, 1);
            checker.SetActive(true);
            checkForMarkerCollision();
        }
        if (Input.GetKeyDown("down"))
        {
            checker.transform.position = checker.transform.position + new Vector3(0, 0, -1);
            checker.SetActive(true);
            //if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out hit, Mathf.Infinity))
                checkForMarkerCollision();
        }
        if (Input.GetKeyDown("left"))
        {
            checker.transform.position = checker.transform.position + new Vector3(-1, 0, 0);
            checker.SetActive(true);
            checkForMarkerCollision();
        }
        if (Input.GetKeyDown("right"))
        {
            checker.transform.position = checker.transform.position + new Vector3(1, 0, 0);
            checker.SetActive(true);
            checkForMarkerCollision();
        }
    }

    void checkForMarkerCollision()
    {
        tempPos = checker.transform.position;
        checker.transform.localPosition = new Vector3(0, 30, 0);
        checker.transform.localPosition = new Vector3(0, 0, 0);
        //checker.SetActive(false);
        Debug.Log("Do something else here");
        this.transform.position = tempPos;
    }
    /*
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("up"))
        {
            checker.transform.position = checker.transform.position + new Vector3(0, 0, 1);
            checker.SetActive(true);
            checkForMarkerCollision();
        }
        if (Input.GetKeyDown("down"))
        {
            checker.transform.position = checker.transform.position + new Vector3(0, 0, -1);
            checker.SetActive(true);
            checkForMarkerCollision();
        }
        if (Input.GetKeyDown("left"))
        {
            checker.transform.position = checker.transform.position + new Vector3(-1, 0, 0);
            checker.SetActive(true);
            checkForMarkerCollision();
        }
        if (Input.GetKeyDown("right"))
        {
            checker.transform.position = checker.transform.position + new Vector3(1, 0, 0);
            checker.SetActive(true);
            checkForMarkerCollision();
        }
    }
    
    void checkForMarkerCollision()
    {    
        tempPos = checker.transform.position;
        checker.transform.localPosition = new Vector3(0, 30, 0);
        checker.transform.localPosition = new Vector3(0, 0, 0);
        //checker.SetActive(false);
        Debug.Log("Do something else here");
        this.transform.position = tempPos;

 
    }
     /*
      void OnCollisionEnter(Collision collision) 
      { 
        if (collision.gameObject.tag == "Panel")
        {
          collided = true;

          Debug.Log("Do something else here");
          checker.transform.localPosition = new Vector3(0, 0, 0);
          Debug.Log("why");
        }         
      }*/

}
