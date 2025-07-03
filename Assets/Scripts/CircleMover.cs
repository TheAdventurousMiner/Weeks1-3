using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleMover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool ifRightArrowIsPressed = Input.GetKey(KeyCode.RightArrow);

        Vector3 newRightPos = transform.position - Vector3.right * 0.1f;

        bool ifUpArrowIsPressed = Input.GetKeyUp(KeyCode.UpArrow);

        Vector3 newUpPos = transform.position - Vector3.up * 0.1f;

        bool ifDownArrowIsPressed = Input.GetKeyDown(KeyCode.DownArrow);

        Vector3 newDownPos = transform.position - Vector3.up * 0.5f;

        if(ifRightArrowIsPressed)
        {
            transform.position = newRightPos;
        }

        if (ifUpArrowIsPressed)
        {
            transform.position = newUpPos;
        }

        if (ifDownArrowIsPressed)
        {
            transform.position = newDownPos;
        }

    }
}
