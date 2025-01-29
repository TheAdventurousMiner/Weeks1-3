using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeFollow : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Make object follow the direction of the mouse
        Vector3 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //set the z position to 0 since scene is 2D
        mouse.z = 0;
        Vector2 direction = mouse - transform.position;

        transform.up = direction;
    }
}
