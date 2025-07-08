using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Looker : MonoBehaviour
{
    public Camera gameCam;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 newRotation = transform.eulerAngles;
        //newRotation.z += 1f;
        //transform.eulerAngles = newRotation;

        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0f;

        Vector3 start = transform.position;
        Vector3 end = mousePos;

        Vector3 direction = end - start;

        transform.up = direction;
    }
}
