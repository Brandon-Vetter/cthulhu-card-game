using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace gameManager {
    public class hand : MonoBehaviour
    {
        // Start is called before the first frame update
        List<GameObject> han = new List<GameObject>();
        private GameObject drawpile;
        private bool turn;
        private int slots;
        private int y;
        private int xmin;
        private int xmax;
        private int selector;
        void Start()
        {
            slots = 3;
            y = 20;
            xmin = -5;
            xmax = 5;
            selector = 1;
            turn = false;
            drawpile = GameObject.Find("drawPile");
            draw();
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
        public void drawCards()
        {
            return;
        }

    }
}