using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chaser : MonoBehaviour
{
    public Vector3 newPosition;
    public Camera gameCam;
    public float speed;
    Vector3 lastClickedPosition = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      

        Vector3 mousePosition = gameCam.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0f;

        if(Input.GetMouseButtonDown(0))
        {
            lastClickedPosition = mousePosition;
        }

        Vector3 start = transform.position;
        Vector3 target = lastClickedPosition;
        Vector3 directionToMove = target - start;

        transform.position = transform.position + directionToMove * speed;
    }
}
