using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RGBChanger : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKey(KeyCode.R))
        {
            gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
        if (Input.GetKey(KeyCode.G))
        {
            gameObject.GetComponent<Renderer>().material.color = Color.green;
        }
        if (Input.GetKey(KeyCode.B))
        {
            gameObject.GetComponent<Renderer>().material.color = Color.blue;
        }
        /*else {
            gameObject.GetComponent<Renderer>().material.color = Color.grey;
        }*/
    }
}
