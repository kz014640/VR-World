using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandler : MonoBehaviour
{
    public GameObject elevator = GameObject.FindGameObjectWithTag("elevator");
   
    public void Move()
    {
        Debug.Log("Hello");
        Debug.Log(elevator.transform.position);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
