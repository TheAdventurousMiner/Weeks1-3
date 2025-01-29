using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TonguePos : MonoBehaviour
{
    float tspeed = 0.01f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        pos.y += tspeed;

        Vector2 TongueMove = Camera.main.WorldToScreenPoint(pos);

        if (TongueMove.y > 0.4 || TongueMove.y < -0.3)
        {
            tspeed = tspeed * -1;
        }

        transform.position = pos;
    }
}
