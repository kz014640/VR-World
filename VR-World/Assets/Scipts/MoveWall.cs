using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWall : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed;
    public Transform target;
    public bool raised = false;

    // Use this for initialization
    void Start()
    {
        //Vector3 target = new Vector3 (transform.position.x, transform.position.y + 3, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (raised == true)
        {
            Debug.Log("Moving Wall");
            float step = speed * Time.deltaTime;
            //transform.Translate (0,Time.deltaTime,0,Space.World);
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        }
    }

    public void raiseTheWall()
    {
        Debug.Log("Moving Wall");
        raised = true;
        Debug.Log("Moving Wall");
        float step = speed * Time.deltaTime;
        //transform.Translate (0,Time.deltaTime,0,Space.World);
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
    }
    
}
