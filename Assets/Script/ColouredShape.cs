using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColouredShape : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer.color = Color.white;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (mouse.x < 1.5 && mouse.x > -1.5 && mouse.y < 1.5 && mouse.y > -1.5)
        {
            spriteRenderer.color = Color.red;
        }
        else
        {
            spriteRenderer.color = Color.white;
        }
    }
}
