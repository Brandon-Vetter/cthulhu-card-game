using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using cards;

namespace gameManager
{ 
    public class discardPile : MonoBehaviour
    {
        // Start is called before the first frame update
        private List<GameObject> cardL;
        public void Start()
        {
            cardL = new List<GameObject>();
        }


        public GameObject getDiscardPile(int ind)
        {
            return cardL[ind];
        }
        public void addDiscardPile(GameObject car)
        {
            cardL.Add(car);
        }
        public void removeCard(int ind)
        {
            cardL.RemoveAt(ind);
        }
    }
}