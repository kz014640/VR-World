using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lift : MonoBehaviour
{

    private bool pressedButton = false;
    private bool isElevatorUp = false;
    GameObject target; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnMouseOver()
    {
        pressedButton = true; 
    }

    void OnMouseExit()
    {
        pressedButton = false;
    }

    void OnGUI()
    {
        if (pressedButton == true)
        {
            GUI.Box(new Rect(300, 300, 200, 20), "Press to use lift"); 
        }
    }

    void OnMouseDown()
    {   if(isElevatorUp == false)
        {
            target = GameObject.Find("Elevator");
            target.GetComponent<Animation>().Play("Up");
            isElevatorUp = true;
        }
        else
        {
            target = GameObject.Find("Elevator");
            target.GetComponent<Animation>().Play("Down");
            isElevatorUp = false; 
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
