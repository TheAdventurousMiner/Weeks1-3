using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HourHand : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 handRotator = transform.eulerAngles;
        handRotator.z += speed;
        transform.eulerAngles = handRotator;
    }
}
