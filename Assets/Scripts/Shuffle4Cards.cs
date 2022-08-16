using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shuffle4Cards : MonoBehaviour
{
    [SerializeField] private GameObject cardPrefab;
    
    [SerializeField] private GameObject enemyCardsHolder;
    [SerializeField] private GameObject myCardsHolder;

    [SerializeField] List<CardsData> enemyDeck;
    [SerializeField] List<CardsData> myDeck;


    private void Start()
    {
        DestroyCurrentCardsIn(enemyCardsHolder);
        DestroyCurrentCardsIn(myCardsHolder);

        ShuffleCards(enemyDeck, 4, enemyCardsHolder);
        ShuffleCards(enemyDeck, 4, myCardsHolder);
    }

    private void ShuffleCards(List<CardsData> list, int number, GameObject parent)
    {
        List<CardsData> originalList = new List<CardsData>(list);
        List<CardsData> finalList = new List<CardsData>();

        while (finalList.Count < number && originalList.Count > 0)
        {
            int index = Random.Range(0, originalList.Count);
            finalList.Add(originalList[index]);
            originalList.RemoveAt(index);
        }

        for (int i=0; i < finalList.Count; i++)
        {
            //Instantiate(finalList[i], parent.transform); 

            GameObject newCard = Instantiate(cardPrefab, parent.transform);
            newCard.GetComponent<CardsDataHandler>().cardData = finalList[i];
        }
    }

    private void DestroyCurrentCardsIn(GameObject parent)
    {
        foreach (Transform child in parent.transform)
        {
            GameObject.Destroy(child.gameObject);
        }
    }
}
