using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLev : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GameObject.Find("Player").SendMessage("Next");
    }
}
