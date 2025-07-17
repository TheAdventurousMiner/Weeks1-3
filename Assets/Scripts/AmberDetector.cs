using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmberDetector : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 amberLocation = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if(amberLocation.x > 1 && amberLocation.y > -2)
        {
            spriteRenderer.color = Color.green;
        }
        else
        {
            spriteRenderer.color = Color.red;
        }
    }
}
