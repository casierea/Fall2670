using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{

	[SerializeField] private Text textComponent;
	// Use this for initialization
	void Start ()
	{
		textComponent.text = ("I am a pirate");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
