using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deck : MonoBehaviour
{
    private string[] suit = {"Spades","Hearts","Diamonds","Clubs"};
    private List<card> cards; 
    public deck()
    {
        cards = new List<card>();
    }

    void fillDeck()
    {
        for(int i = 0; i < 4; i++){
            for(int j = 1; j < 14;++j){
                cards.add(new card(suit[i],j));
            }
        }
    }

    card drawCard()
    {
        
        card r = cards[Next(0,51)];
    }
}
