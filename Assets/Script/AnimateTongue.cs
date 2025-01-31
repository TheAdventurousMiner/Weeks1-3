using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class AnimateTongue : MonoBehaviour
{
    //set variables for animation to public
    //set public variable to control animation curve in the Unity
    public AnimationCurve curve;
    //set public transform variables to move the tongue in specific locations
    public Transform starting;
    public Transform finish;

    //set the range for the time and use t to represent time
    [Range(0, 2)]
    private float t;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //use Time.deltaTime to control the timing of the tongue movement
        t += Time.deltaTime;

        //use if statement to reset the location so that the tongue moves in a loop
       if (t > 2)
        {
            t = 0;
        }

       //use Vector2.Lerp to animate the positions of the tongue
        transform.position = Vector2.Lerp(starting.position, finish.position, curve.Evaluate(t));
    }
}
