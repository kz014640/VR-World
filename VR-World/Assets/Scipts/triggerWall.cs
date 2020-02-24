using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerWall : MonoBehaviour
{

    public float speed;
    public Transform targetWall;

    
    // Use this for initialization
    void Start()
    {
        //wall = GameObject.Find("verticalWall_1");
    }

    // Update is called once per frame
    void Update()
    {

    }
   
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            GameObject go = GameObject.Find("Move_wall");
            go.GetComponent<MoveWall>().raiseTheWall();
            Debug.Log("The button clicked, raising the wall");

        }
    }
    

}
