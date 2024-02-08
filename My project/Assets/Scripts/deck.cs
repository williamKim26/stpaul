using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deck : MonoBehaviour
{
    private string[] suit = {"Spades","Hearts","Diamonds","Clubs"};
    private card[,] cards; 
    public deck()
    {
        cards = new card[4,13];
    }

    void fillDeck()
    {
        for(int i = 0; i < 4; i++){
            for(int j = 1; j < 14;++j){
                cards[i,j]= new card(suit[i],j);
            }
        }
    }
}
