using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using gameManager;
using cards;

public class init : MonoBehaviour
{
    private static List<deck> decks;
    // Start is called before the first frame update
    [RuntimeInitializeOnLoadMethod]
    static void OnRuntimeMethodLoad()
    {
        decks = new List<deck>();
        decks.Add(new deck("deck 1"));
        decks.Add(new deck("deck 2"));
        decks.Add(new deck("deck 3"));
    }
    
    static void Quit()
{
}
    // Update is called once per frame
    List<deck> getDecks()
    {
        return decks;
    }
}