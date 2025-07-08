using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chaser : MonoBehaviour
{
    public Vector3 newPosition;
    public Camera gameCam;
    public SpriteRenderer chaserRenderer;
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

        Vector3 chaserPosition = gameCam.WorldToScreenPoint(transform.position);

        float xMin = 0f;
        float yMin = 0f;
        float xMax = Screen.width;
        float yMax = Screen.height;

        //If chaser's x value is less than the xMin
        //If chaser's x value is greater than the xMax
        //If chaser's y value is less than the yMin
        //If chaser's y value is greater than the yMax
        //THEN:
        //Change the colour of the sprite to be red

        bool xMaxExceeded = chaserPosition.x >= xMax;
        bool xMinExceeded = chaserPosition.x <= xMin;

        Debug.Log("xMaxExceeded = " + xMaxExceeded.ToString());
        Debug.Log("xMinExceeded = " + xMinExceeded.ToString());

        if(xMaxExceeded || xMinExceeded)
        {
            chaserRenderer.color = Color.red;
        }
        else
        {
            chaserRenderer.color = Color.white;
        }
    }
}
