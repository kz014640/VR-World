using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMouseLook : MonoBehaviour
{

    Vector2 mouseLook; //keeps track of movement, only used with change
    Vector2 smoothV; //helps smooth the movement, noit necesary
    public float sensitivity = 5.0f; //mouse sensitivity
    public float smoothing = 2.0f; //how much smoothing needed
    GameObject character; //object points to character
    // Start is called before the first frame update
    void Start()
    {
        character = this.transform.parent.gameObject;//parent of the object with the code, therefore the camera
    }

    // Update is called once per frame
    void Update()
    {
        var pd = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y")); //get the movement of the mouse

        pd = Vector2.Scale(pd, new Vector2(sensitivity * smoothing, sensitivity * smoothing));//values are sorted
        smoothV.x = Mathf.Lerp(smoothV.x,pd.x, 1f / smoothing);//slows the movement and performs a lerp(wont instantly move from one thing to another)
        smoothV.y = Mathf.Lerp(smoothV.y, pd.y, 1f / smoothing);
        mouseLook += smoothV;

        transform.localRotation = Quaternion.AngleAxis(-mouseLook.y, Vector3.right);
        character. transform.localRotation = Quaternion.AngleAxis(mouseLook.x, character.transform.up);
    }
}
