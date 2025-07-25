using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannonball : MonoBehaviour
{
    private Vector3 startPosition;
    private Vector3 endPosition;

    private float timePassed;

    public float moveDuration;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        endPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        endPosition.z = 0;

        Destroy(gameObject, moveDuration);
    }

    // Update is called once per frame
    void Update()
    {
        timePassed += Time.deltaTime / moveDuration;

        Vector3 output = Vector3.Lerp(startPosition, endPosition, timePassed);
        transform.position = output;
    }
}
