using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToMain : MonoBehaviour
{
    public string scenename;
    public void gotomain()
    {
        Application.LoadLevel(scenename);
    }
}
