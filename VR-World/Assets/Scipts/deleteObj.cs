using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deleteObj : MonoBehaviour
{
    public GameObject gameObject;
    public string scenename;

    public void OnMouseDown() 

    {
        Application.LoadLevel(scenename);
 
        Destroy(gameObject);
    }
}
