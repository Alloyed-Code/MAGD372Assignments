using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingCounter : MonoBehaviour
{
    private int steps = 0;

    private void OnEnable()
    {
        ButtonPressEvent.buttonPress += CountStep;
    }
    private void OnDisable()
    {
        ButtonPressEvent.buttonPress -= CountStep;
    }

    void CountStep(KeyCode pressed)
    {
        //Debug.Log("RECEIVED");
        if (pressed == KeyCode.W) 
        {
            steps++;
            Debug.Log("event W pressed received");
            Debug.Log("Total of " + steps + " so far");

        }
    }
}
