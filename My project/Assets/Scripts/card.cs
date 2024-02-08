using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]


public class card : MonoBehaviour
{
    private string suit;
    private int rank;
    
    public card(string suit, int rank)
    {
        this.suit = suit;
        this.rank = rank;
    }
}
