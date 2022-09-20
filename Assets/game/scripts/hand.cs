using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using gameManager;

public class hand : MonoBehaviour
{
    // Start is called before the first frame update
    List<GameObject> han = new List<GameObject>();
    [SerializeField] public GameObject drawpile;
    int y;
    int xmax;
    int xmin;
    void Start()
    {
        y = -5;
        xmax = 5;
        xmin = -5;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void draw()
    {
        GameObject car = drawpile.GetComponent<drawPile>().draw();
        if(car == null) return;
        han.Add(car);
    }

}
