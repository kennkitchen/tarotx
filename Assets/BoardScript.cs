using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class BoardScript : MonoBehaviour
{
    private string[] cardDeck = new string[]
    {
        "ar00", "ar01", "ar02", "ar03", "ar04", "ar05", "ar06", "ar07", "ar08","ar09", "ar10",
        "ar11", "ar12", "ar13", "ar14", "ar15", "ar16", "ar17", "ar18", "ar19", "ar20", "ar21",
        "cupa", "cuac", "cu02", "cu03", "cu04", "cu05", "cu06", "cu07", "cu08","cu09", "cu10",
        "cuki", "cukn", "cuqu",
        "pepa", "peac", "pe02", "pe03", "pe04", "pe05", "pe06", "pe07", "pe08","pe09", "pe10",
        "peki", "pekn", "pequ",
        "swpa", "swac", "sw02", "sw03", "sw04", "sw05", "sw06", "sw07", "sw08","sw09", "sw10",
        "swki", "swkn", "swqu",
        "wapa", "waac", "wa02", "wa03", "wa04", "wa05", "wa06", "wa07", "wa08","wa09", "wa10",
        "waki", "wakn", "waqu"
    };

    private float[] cardPositions = new float[]
    {
        -2.96f, 0f, 0f,
        -2.0f, 0f, 0f,
        -2.92f, -3.27f, 0f,
        -6.32f, 0f, 0f,
        -2.99f, 3.32f, 0f,
        0.73f, 0f, 0f,
        4.15f, -3.41f, 0f,
        5.89f, -1.39f, 0f,
        4.09f, 0.71f, 0f,
        5.61f, 3.48f, 0f
    };

    private string[] cardsUsed = new string[77];
    
    private SpriteRenderer sprRend;
    private GameObject CardX;
    
    // Start is called before the first frame update
    void Start()
    {

        for (int i = 0; i < 10; i++)
        {
            CardX = new GameObject("CardX");
            
            //CardX.transform.Translate(0.0f, 0.0f, 0.0f);
            CardX.transform.position = new Vector3(cardPositions[i * 3], cardPositions[(i * 3) + 1], cardPositions[(i * 3) + 2]);
            
            CardX.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);

            sprRend = CardX.AddComponent(typeof(SpriteRenderer)) as SpriteRenderer;
        
            sprRend.sprite = Resources.Load<Sprite>(pickACard(i));
            sprRend.sortingOrder = 1;
            sprRend.size = new Vector2(0.5f, 0.5f);
            
            if (i == 1)
            {
                CardX.transform.rotation = Quaternion.Euler(0f, 0f, 90f);
                sprRend.sortingOrder = 2;
            }

            //CardX.AddComponent(typeof(EventHandler));
            

        }

    }

    private string pickACard(int i) 
    {
        var cardIndex = UnityEngine.Random.Range(0, 77);
        var card = "tarot/" + cardDeck[cardIndex];
        
        while (cardsUsed.Contains(card))
        {
            cardIndex = UnityEngine.Random.Range(0, 77);
            card = "tarot/" + cardDeck[cardIndex];
        }

        cardsUsed[i] = card;

        return card;
    }
}
