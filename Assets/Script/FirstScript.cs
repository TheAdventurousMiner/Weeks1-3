using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    float speed = 0.01F;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        pos.x += speed;

        Vector2 SqureInScreenSpace = Camera.main.WorldToScreenPoint(pos);

        if(SqureInScreenSpace.x < 0 || SqureInScreenSpace.x > Screen.width)
        {
            speed = speed * -1;
        }

        transform.position = pos;
    }
}
