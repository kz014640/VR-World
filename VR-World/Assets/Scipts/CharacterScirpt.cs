using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterScirpt : MonoBehaviour
{

    public float speed = 10.0F;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; //lock mouse in so cant move around
    }

    // Update is called once per frame
    void Update()
    {
        float movement = Input.GetAxis("Vertical") * speed; //up and down movement, uses 'Horizontal as these are the buttons from the 'input section'
        float sidetoside = Input.GetAxis("Horizontal") * speed; //side to side movement
        movement *= Time.deltaTime;
        sidetoside *= Time.deltaTime;
        transform.Translate(sidetoside, 0, movement);

        if (Input.GetKeyDown("escape")) //if user selects escape
        {
            Cursor.lockState = CursorLockMode.None; //remove lock state and let the mouse free
        }
    }
}
