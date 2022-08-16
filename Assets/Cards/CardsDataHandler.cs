using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CardsDataHandler : MonoBehaviour
{
    public CardsData cardData;

    [SerializeField] private TMP_Text country;
    [SerializeField] private TMP_Text rarity;
    [SerializeField] private TMP_Text cardName;
    [SerializeField] private TMP_Text stars;
    [SerializeField] private TMP_Text power;
    [SerializeField] private TMP_Text damage;

    [SerializeField] private Image image;

    void Start()
    {
        country.text = cardData.cardCountry;
        rarity.text = cardData.cardRarity;
        cardName.text = cardData.cardName;
        stars.text = cardData.cardLevel.ToString();
        power.text = cardData.cardPower[0].ToString();
        damage.text = cardData.cardDamage[0].ToString();

        image.sprite = cardData.cardImageMax[0];
    }
}
