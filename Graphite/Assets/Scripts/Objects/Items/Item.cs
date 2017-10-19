using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;


public class Item : MonoBehaviour
{
    public int value;
    public Creature holder;

    //public Item(int val, Creature holder = null)
    //{
    //    value = val;
    //    this.holder = holder;
    //}

    public virtual void Awake()
    {

    }

    public virtual void Update()
    {            
        if (isMouseIn() && Input.GetMouseButtonDown(0))
        {
            Creature foo = GameObject.Find("Player").GetComponent<Creature>();
            foo.pickupItem(this);
            Destroy(this.gameObject);
        }
    }

    bool isMouseIn()
    {
        return GetComponent<Collider2D>().bounds.Contains((Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition));
    }
}

