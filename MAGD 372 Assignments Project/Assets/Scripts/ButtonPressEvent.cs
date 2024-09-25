using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;

public class ButtonPressEvent : MonoBehaviour
{
    public delegate void ButtonPressDelegate(KeyCode pressedKey);
    public static event ButtonPressDelegate buttonPress;

    private KeyCode[] movementKeys = new KeyCode[8]
    {KeyCode.W,KeyCode.A,KeyCode.S,KeyCode.D,KeyCode.UpArrow,KeyCode.DownArrow,KeyCode.LeftArrow,KeyCode.RightArrow};
    private void Update()
    {
        //if (Input.anyKeyDown)
        //string key = Input.inputString;
        //Debug.Log(key);
        //if (key != null)
        //{
        //KeyCode keyCode = (KeyCode)Enum.Parse(typeof(KeyCode), key, true);
        //if (!movementKeys.Contains<KeyCode>(keyCode))

        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            if (buttonPress != null)
            {
                Debug.Log("Event enter pressed sent");
                buttonPress(KeyCode.KeypadEnter);
            }
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            if (buttonPress != null)
            {
                Debug.Log("Event W pressed sent");
                buttonPress(KeyCode.W);
            }
        }
        //}
        //}
    }
}
