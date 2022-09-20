using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using cards;

namespace gameManager
{
    public class drawPile : MonoBehaviour
    {
        // Start is called before the first frame update
        private List<GameObject> cardL;
        public void Start()
        {
            cardL = new List<GameObject>(); 
            deck decks = new deck("deck 1");
            while(decks.getDeck().Count != 0)
            {
                int randRm = Random.Range(0, decks.getDeck().Count);
                cardL.Add(decks.getDeck()[randRm]);
                decks.removeCard(randRm);
            }
        }
        public GameObject draw()
        {
            if(cardL.Count == 0) return null;
            GameObject retVal = cardL[0];
            cardL.RemoveAt(0);
            return retVal;
        }

        public GameObject getDrawPile(int ind)
        {
            return cardL[ind];
        }
        public void addDrawPile(GameObject car)
        {
            cardL.Add(car);
        }
        public void removeCard(int ind)
        {
            cardL.RemoveAt(ind);
        }
    }
}