using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;
using cards;
namespace gameManager
{
    public class deck
    {
        // Start is called before the first frame update
        private string deckName;
        private string path;
        private List<GameObject> cardL;

        public deck(string d = "deck",string p = "Assets/game/cards/savedDecks/")
        {

            deckName = d;
            path = p;
            cardL = new List<GameObject>();
            // reads the deck file and finds the cards with id inside file
            if (File.Exists(path + deckName + ".dek"))
            {
                List<string> cardsInFile = new List<string>();
                Object[] AvalableCards = Resources.LoadAll("cards", typeof(GameObject));
                foreach (GameObject curCar in AvalableCards)
                {
                    if (!File.Exists("Assets/game/cards/cards/" + curCar.GetComponent<card>().getID())) break;
                    curCar.GetComponent<card>().fromYaml("Assets/game/cards/cards/" + curCar.GetComponent<card>().getID());
                }
                StreamReader read = new StreamReader(path + deckName + ".dek");
                while(!read.EndOfStream)
                {
                    string line = read.ReadLine();
                    foreach(GameObject curcard in AvalableCards)
                    {
                        if(curcard.GetComponent<card>().getID() == int.Parse(line))
                        {
                            cardL.Add(curcard);
                        }
                    }
                }
                read.Close();
                Debug.Log("Deck: " + deckName + " loaded");
            }
        }
        public void addCard(GameObject car)
        {
            cardL.Add(car);
        }
        public void setName(string nam)
        {
            if(nam.Equals(""))
            {
                deckName = nam;
            }
        }
        public void setPath(string pat)
        {
            if (pat.Equals(""))
            {    
                path = pat;
            }
        }
        public void removeCard(int ind)
        {
            cardL.RemoveAt(ind);
        }
        public List<GameObject> getDeck()
        {
            return cardL;
        }
        public void saveDeck()
        {
            // creates a file if it does not exist, writes the deck to the file
            if(!File.Exists(path + deckName + ".dek"))
            {
                using (FileStream fs = File.Create(path + deckName + ".dek"));
            }
            StreamWriter writer = new StreamWriter(path + deckName + ".dek", true);
            foreach (GameObject car in cardL)
            {
                writer.WriteLine(car.GetComponent<card>().getID());
            }
            writer.Close();
        }
    }
}