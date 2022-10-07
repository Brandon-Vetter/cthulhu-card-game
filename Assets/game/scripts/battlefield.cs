using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Physics2DModule;

public class battlefield : MonoBehaviour
{
    // Start is called before the first frame update
    private double x;
    private double y;
    private double xs;
    private double ys;
    private BoxCollider2D area;
    void Start()
    {
        area = this.GetComponent<BoxCollider2D>();
        x = area.offset[0];
        y = area.offset[1];
        xs = area.size[0];
        ys = area.size[1];
        Debug.Log(x);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
