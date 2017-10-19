using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttributeBlock{

    private int health;
    private int mana;
    private int strength;
    private int dexterity;
    private int intellect;
    private int constitution;
    private float maxSpeed;

    public AttributeBlock(int hp = 10, int mana = 10, int str = 1, int dex = 1, int intel = 1, int con = 1, float maxspd = 0.2f)
    {
        health = hp;
        this.mana = mana;
        strength = str;
        dexterity = dex;
        intellect = intel;
        constitution = con;
        maxSpeed = maxspd;
    }

    public int Health
    {
        get
        {
            return health;
        }

        set
        {
            health = health - value < 0 ?  0 : health - value;
        }
    }

    public int Mana
    {
        get
        {
            return mana;
        }

        set
        {
            mana = mana - value < 0 ? 0 : mana - value;
        }
    }

    public int Strength
    {
        get
        {
            return strength;
        }

        set
        {
            strength = value;
        }
    }

    public int Dexterity
    {
        get
        {
            return dexterity;
        }

        set
        {
            dexterity = value;
        }
    }

    public int Intellect
    {
        get
        {
            return intellect;
        }

        set
        {
            intellect = value;
        }
    }

    public int Constitution
    {
        get
        {
            return constitution;
        }

        set
        {
            constitution = value;
        }
    }

    public float MaxSpeed
    {
        get
        {
            return maxSpeed;
        }

        set
        {
            maxSpeed = value;
        }
    }
}
