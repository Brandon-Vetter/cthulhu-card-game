using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using cards;

namespace gameManager {
    public class hand : MonoBehaviour
    {
        // Start is called before the first frame update
        List<GameObject> han = new List<GameObject>();
        private GameObject drawpile;
        private bool turn;
        private int slots;
        void Start()
        {
            slots = 3;
            turn = false;
            drawpile = GameObject.Find("drawPile");
            draw();
            Debug.Log(han.Count);
        }

        // Update is called once per frame
        void Update()
        {
            if (!turn) return;

        }
        public void draw()
        {
            GameObject car = drawpile.GetComponent<drawPile>().draw();
            if(car == null) return;
            Debug.Log(car.GetComponent<card>().getName());
            han.Add(car);
        }
        public void takeTurn()
        {
            draw();
            turn = true;
        }
        public bool getTurnStatus()
        {
            return turn;
        }

    }
}