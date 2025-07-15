using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool moveFoward = Input.GetKey(KeyCode.D);

        Vector3 newForwardPos = transform.position - Vector3.left * 0.01f;

        bool moveBack = Input.GetKey(KeyCode.A);

        Vector3 newBackPos = transform.position - Vector3.right * 0.01f;

        if(moveFoward)
        {
            transform.position = newForwardPos;
        }

        if (moveBack)
        {
            transform.position = newBackPos;
        }
    }
}
