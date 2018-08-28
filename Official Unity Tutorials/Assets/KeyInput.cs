﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyInput : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        bool down = Input.GetKeyDown(KeyCode.Space);
        bool held = Input.GetKey(KeyCode.Space);
        bool up = Input.GetKeyUp(KeyCode.Space);
        if (down)
        {
            Debug.Log("button down");
        }
        else if (held)
        {
            Debug.Log("button held");
        }
        else if (up)
        {
            Debug.Log("button up");
        }
        else
        {
            Debug.Log("default");
        }

     /*   void Update()
        {
            bool down = Input.GetButtonDown("Jump");
            bool held = Input.GetButton("Jump");
            bool up = Input.GetButtonUp("Jump");

            if (down)
            {
                graphic.texture = downgfx;
            }
            else if (held)
            {
                graphic.texture = heldgfx;
            }
            else if (up)
            {
                graphic.texture = upgfx;
            }
            else
            {
                graphic.texture = standard;
            }

            guiText.text = " " + down + "\n " + held + "\n " + up;
        }
*/

    }
	
}
