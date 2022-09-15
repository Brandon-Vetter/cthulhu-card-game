using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace cards
{
    public class card : MonoBehaviour
    {

        private int[] cost;
        private string name;



        // Start is called before the first frame update
        void Start()
        {
            name = "card";
        }

        // Update is called once per frame
        void Update()
        {

        }
        public string getName()
        {
            return name;
        }
    }
}
