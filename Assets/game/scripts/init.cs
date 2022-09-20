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