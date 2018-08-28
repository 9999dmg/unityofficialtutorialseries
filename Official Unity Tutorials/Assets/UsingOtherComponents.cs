using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsingOtherComponents : MonoBehaviour {

    public GameObject otherGameObject;

    private AnotherScript anotherScript; //script attached to same object
    private YetAnotherScript yetAnotherScript; //script attached to different object
	// Use this for initialization

    void Awake()
    {
        anotherScript = GetComponent<AnotherScript>();
        yetAnotherScript = otherGameObject.GetComponent<YetAnotherScript>();
    }

	void Start () {
        Debug.Log("The player's score is " + anotherScript.playerScore);
        Debug.Log("The player has died " + yetAnotherScript.numberOfPlayerDeaths + " times");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
