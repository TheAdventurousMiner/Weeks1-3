using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Changer : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    float timeAlive = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeAlive += Time.deltaTime;

        if(timeAlive > 3)
        {
            spriteRenderer.color = Color.green;
        }
    }
}
