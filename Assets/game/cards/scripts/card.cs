using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
namespace cards
{
    public class card : MonoBehaviour
    {
        [SerializeField]private int id;
        private int[] cost;
        //[SerializeField] public string name;



        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
        public string getName()
        {
            return name;
        }
        public int getID()
        {
            return id;
        }
    }
}
