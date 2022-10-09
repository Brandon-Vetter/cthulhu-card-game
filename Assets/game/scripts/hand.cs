using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
<<<<<<< HEAD
=======
using cards;
>>>>>>> e55d235b2adbc8e1fd830bdd52fbb2297e875443

namespace gameManager {
    public class hand : MonoBehaviour
    {
        // Start is called before the first frame update
        List<GameObject> han = new List<GameObject>();
        private GameObject drawpile;
        private bool turn;
        private int index;
        private int slots;
<<<<<<< HEAD
        private int y;
        private int xmin;
        private int xmax;
        private int selector;
=======
        private bool selected;
>>>>>>> e55d235b2adbc8e1fd830bdd52fbb2297e875443
        void Start()
        {
            selected = false;
            index = 0;
            slots = 3;
<<<<<<< HEAD
            y = 20;
            xmin = -5;
            xmax = 5;
            selector = 1;
=======
>>>>>>> e55d235b2adbc8e1fd830bdd52fbb2297e875443
            turn = false;
            drawpile = GameObject.Find("drawPile");
            draw(5);
            showCards();
        }

        // Update is called once per frame
        void Update()
        {
            if(Input.GetKeyUp(KeyCode.RightArrow) && index != (han.Count - 1) && !selected)
            {
                index++;
            }
            else if(Input.GetKeyUp(KeyCode.LeftArrow) && index != 0 && !selected)
            {
                index--;
            }
            else if(Input.GetKeyUp(KeyCode.Space))
            {
                selected = !selected;
                Outline outl = this.GetComponent<RectTransform>().GetChild(1).gameObject.GetComponent<Outline>();
                outl.enabled = !outl.enabled;
            }
            showCards();
            if (!turn) return;

        }
        public void draw(int num = 1)
        {
            for(int i = 0; i < num ;i++)
            {
                GameObject car = drawpile.GetComponent<drawPile>().draw();
                if(car == null) return;
                han.Add(car);
            }
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
<<<<<<< HEAD
        public void drawCards()
        {
            return;
=======
        public void showCards()
        {
            for(int i = -1; i<2 ; i++)
            {
                Image img = this.GetComponent<RectTransform>().GetChild(i+1).gameObject.GetComponent<Image>();
                if(index + i >= 0 && index + i < han.Count)
                {
                    SpriteRenderer cur = han[index + i].GetComponent<SpriteRenderer>();
                    img.sprite = cur.sprite;
                    img.color = cur.color;
                    img.enabled = true;
                }
                else
                {
                    img.enabled = false;
                }
            }
        }
        public int getIndex()
        {
            return index;
        }
        public bool getSelected()
        {
            return selected;
>>>>>>> e55d235b2adbc8e1fd830bdd52fbb2297e875443
        }

    }
}