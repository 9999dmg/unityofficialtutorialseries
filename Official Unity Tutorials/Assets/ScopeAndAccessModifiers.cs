using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScopeAndAccessModifiers : MonoBehaviour 
{

    public int alpha; 

    //code blocks are usually what define a variables scope. Everything here is local to the ScopeAndAccessModifiers class//
    //alpha, beta, gamma are local (in scope)  within the ScopeAndAccessModifiers class//

    private int beta = 0;
    private int gamma = 5;

    private AnotherClass myOtherClass;

    /*
    void Start()
    {
        alpha = 29;
        myOtherClass = new AnotherClass(); //instance of class AnotherClass
        myOtherclass.FruitMachine(alpha, myOtherClass.apples);
    }

*/
    // Use this for initialization
    void Example (int pens, int crayons) //pens, crayons, answer are all local (in scope) to Example function//
    {
        int answer;
        answer = pens * crayons * alpha;
        Debug.Log(answer);

    }


    // Update is called once per frame
    void Update () {
        Debug.Log("Alpha is set to: " + alpha);
	}
}
