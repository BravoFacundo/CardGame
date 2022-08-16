using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Card", menuName = "Cards/Card")]
public class CardsData : ScriptableObject
{
    public string cardID;
    
    [Header("Info")]    
    public string cardName;    //(Name of the card character)
    public string cardCountry; //(Country of the card character)
    public string cardRarity;  //(Tier C, Tier B, Tier A, Tier S)
    [TextArea(0, 30)]
    public string cardDescription;

    [Header("Data")]
    public int cardLevel;    //Estrellas (Min 1 - Max 5)
    public int[] cardPower;  //Pelea     (Min 1 - Max 10)
    public int[] cardDamage; //Vida      (Min 1 - Max 10)

    [Header("Cosmetic")]
    public Sprite[] cardImageMax;  //(Images of the card character)
    public Sprite[] cardImageCut;

}
