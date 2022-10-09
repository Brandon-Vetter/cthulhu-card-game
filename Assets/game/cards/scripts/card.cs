using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using YamlDotNet.Serialization;
namespace cards
{
    public class card : MonoBehaviour
    {
        [SerializeField] private int id;
        public List<string> keywords { set; get; }
        public int strength { set; get; }
        public int will { set; get; }
        public int cost { set; get; }
        public string text { set; get; }
        public string name { set; get; }
        public int spellType { set; get; }
        public string typeName { set; get; }
        public enum spellNum { creature = 1, ritual = 2, incantation = 3 };
        public enum keyword { massive = 1, warping = 2, manifest = 3, dying_breath = 4, initiation = 5, burn = 6 };


        // Start is called before the first frame update
        void Start()
        {
            keywords = new List<string>();
            strength = 0;
            will = 0;
            cost = 0;
            text = "";
            name = "";
            spellType = 0;
            typeName = "";
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
        public card fromYaml(string fName)
        {
            card returned;
            using (FileStream fin = File.OpenRead(fName))
            {
                TextReader reader = new StreamReader(fin);

                var deserializer = new Deserializer();
                returned = deserializer.Deserialize<card>(reader);
            }
            return returned;
        }
    }
}
