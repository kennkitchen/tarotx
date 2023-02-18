using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DealCards : MonoBehaviour
{
    public GameObject card;
    private GameObject[] cards;
    public int cardIndex;
    
    // Start is called before the first frame update
    void Start()
    {
        cards = GameObject.FindGameObjectsWithTag("Card");
        newDeal(cards);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void newDeal(GameObject[] cards)
    {
        cardIndex = UnityEngine.Random.Range(0, 2);
        card = cards[cardIndex];
        Debug.Log(cardIndex.ToString());
        Instantiate(card, new Vector3(0, 0, 0), transform.rotation);
    }
}
