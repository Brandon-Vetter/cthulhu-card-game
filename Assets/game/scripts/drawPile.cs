using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using cards;

public class drawPile : MonoBehaviour
{
    // Start is called before the first frame update
    private List<card> cardL;
    public void Start()
    {
        cardL = new List<card>(); 
    }


    public card getDrawPile(int ind)
    {
        return cardL[ind];
    }
    public void addDrawPile(card car)
    {
        cardL.Add(car);
    }
    public void removeCard(int ind)
    {
        cardL.RemoveAt(ind);
    }
}
