using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pacer : MonoBehaviour
{
    public float speed;
    private float direction = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.right * speed * direction * Time.deltaTime;

        Vector3 pacerPosition = Camera.main.WorldToScreenPoint(transform.position);

        if(pacerPosition.x > Screen.width)
        {
            direction *= -1f;
        }
        if (pacerPosition.x < 0)
        {
            direction *= -1f;
        }
        
    }
}
