using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;


public class Spell : MonoBehaviour
{
    private int cost;
    private float range;
    //Spell Type?? Maybe enum?? Line, Ball, Cone, 


    //Sprite stuff and colliders and whatever

    public Spell(int cost, float range)
    {
        this.cost = cost;
        this.range = range;
    }

    public int Cost
    {
        get
        {
            return cost;
        }
    }

    public float Range
    {
        get
        {
            return range;
        }

    }

    public void cast()
    {
             
    }
}

