using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareMover : MonoBehaviour
{
    //Class variables go here
    public float speed;
    public float xMax;
    public float xMin;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

       
        Vector3 newPos = transform.position + Vector3.right * speed;

        transform.position = newPos;

        if(transform.position.x > xMax || transform.position.x < xMin)
        {
            speed = speed * -1;
        }

    }
}
