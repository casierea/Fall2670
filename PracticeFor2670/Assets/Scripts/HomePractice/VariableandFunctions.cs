using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableandFunctions : MonoBehaviour
{
	private int myInt = 5;
	
	// Use this for initialization
	void Start ()
	{

		myInt = MultiplyByTwo(myInt);
		Debug.Log(myInt);
	}

	int MultiplyByTwo(int number)
	{
		int result;
		result = number * 2;
		return result;
	}
	// Update is called once per frame
	void Update () {
		
	}
}
