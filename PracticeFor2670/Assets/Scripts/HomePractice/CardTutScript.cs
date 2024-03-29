﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "CatCard")]
public class CardTutScript : ScriptableObject
{

	public new string name;
	public string description;
	public Sprite artwork;

	public int manaCost;
	public int attack;
	public int health;
	public int cuddleCost;
	public int sleepHours;
	public int happiness;

	public void Print()
	{
		Debug.Log(name + ":" + description + "The card costs" + ":" + manaCost);
	}


}
