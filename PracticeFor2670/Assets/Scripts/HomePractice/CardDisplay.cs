using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{

	public CardTutScript card;
	public Text nameText;
	public Text descriptionText;
	public Image artworkImage;

	public Text manaText;
	public Text attackText;
	public Text healthText;
	
	
	// Use this for initialization
	void Start () {
		//Debug.Log(card.name);
		card.Print();
	}
	
}
