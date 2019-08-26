using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{

    public CardTutorialScript card;
    public Text nameText;
    public Text descriptionText;
    public Image artworkImage;

    public Text manaText;
    public Text attackText;
    public Text healthText;
    public Text cuddleCostText;
    public Text sleepHoursText;
    public Text happinessText;
	
	
    // Use this for initialization
    void Start () {
        //card.Print(); // prints card to console
        nameText.text = card.name;
        descriptionText.text = card.description;
        artworkImage.sprite = card.artwork;
        manaText.text = card.attack.ToString();
        attackText.text = card.attack.ToString();
        healthText.text = card.health.ToString();
        cuddleCostText.text = card.cuddleCost.ToString();
        sleepHoursText.text = card.sleepHours.ToString();
        happinessText.text = card.happiness.ToString();

    }
	
}