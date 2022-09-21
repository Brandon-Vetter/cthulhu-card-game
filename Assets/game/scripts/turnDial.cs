using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace gameManager
{ 
    public class turnDial : MonoBehaviour
    {
        // Start is called before the first frame update
        private bool turn;
        private bool upkeep;
        private GameObject player;
        void Start()
        {
            player = GameObject.Find("hand");
            turn = true;
            upkeep = false;
        }

        // Update is called once per frame
        void Update()
        {
            if(turn)
            {
                player.GetComponent<hand>().takeTurn();
                while (player.GetComponent<hand>().getTurnStatus());
                turn = false;
            }
        }

    }
}