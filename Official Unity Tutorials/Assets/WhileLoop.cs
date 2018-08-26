using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoop : MonoBehaviour {

    int cupsInTheSink = 4;

	// Use this for initialization
	void Start () 
    {
        while(cupsInTheSink > 0)
        {
            Debug.Log("I've washed a cup!");
            cupsInTheSink--;
            Debug.Log(cupsInTheSink);
        }
	}
}
