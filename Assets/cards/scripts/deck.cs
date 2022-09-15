using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using cards;

public class deck : MonoBehaviour
{
    // Start is called before the first frame update
    private string deckName = "deck";
    private string path = "Assets/cards/savedDecks/";
    private List<card> cardL;
    void Start()
    {
        cardL = new List<card>();
        if(File.Exists(path + deckName + ".dek"))
        {
            List<string> cardsInFile = new List<string>();
            foreach (string line in File.ReadLines(path + deckName + ".dek"))
            {
                cardsInFile.Add(line);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    void addCard(card car)
    {
        cardL.Add(car);
    }
    void setName(string nam)
    {
        if(nam.Equals(""))
        {
            name = nam;
        }
    }
    void setPath(string pat)
    {
        if (pat.Equals(""))
        {    
            path = pat;
        }
    }
    void removeCard(string nam)
    {
        foreach (card car in cardL)
        {
            if (car.getName().Equals(nam))
            {
                cardL.Remove(car);
            }
        }
    }
    List<card> getDeck()
    {
        return cardL;
    }
    void saveDeck()
    {
        StreamWriter writer = new StreamWriter(path + deckName + ".dek", true);
        writer.WriteLine(deckName);
        writer.WriteLine(path);
        foreach (card car in cardL)
        {
            writer.WriteLine(car.getName());
        }
        writer.Close();
    }
}
