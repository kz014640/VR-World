using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elevator : MonoBehaviour
{

    public GameObject movePlatform;

    private void OnTriggerStay()
    {
        Debug.Log(movePlatform.transform.position.y); 
        if(movePlatform.transform.position.y <= 60)
        {
            movePlatform.transform.position += movePlatform.transform.up * 5*Time.deltaTime; 
        }
        

    }
    private void OnTriggerExit()
    {
        while (movePlatform.transform.position.y >= 1)
        {
            movePlatform.transform.position -= movePlatform.transform.up * 5 * Time.deltaTime;
        }
    }
}
