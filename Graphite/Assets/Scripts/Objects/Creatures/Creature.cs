using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;


public abstract class Creature : MonoBehaviour
{

    protected Vector2 position;
    protected Rigidbody2D rb;

    public AttributeBlock stats;
    protected Inventory inventory;

    //Equipped stuff
    private Weapon equippedWeapon;
    private Armor equippedArmor;

    #region Properties
    public Weapon EquippedWeapon
    {
        get
        {
            return equippedWeapon;
        }

        set
        {
            equippedWeapon = value;
        }
    }

    public Armor EquippedArmor
    {
        get
        {
            return equippedArmor;
        }

        set
        {
            equippedArmor = value;
        }
    }
    #endregion
    //Trinket??

    public virtual void Awake()
    {
        position = new Vector2();
        stats = new AttributeBlock();
        inventory = new Inventory();
        rb = GetComponent<Rigidbody2D>();

        stats = new AttributeBlock();
        inventory = new Inventory();
    }

    public virtual void Update()
    {
        if (GetComponent<Collider2D>().bounds.Contains(Input.mousePosition))
        {
            Debug.Log("Stuff");
        }

        //If creature doesn't have a weapon, give it a weak unarmed attack
        //if (EquippedWeapon == null) EquippedWeapon = new Weapon(new DamageRange(1, 1));
    }

    public void heal(int amount)
    {
        stats.Health += Math.Abs(amount);
    }

    public void hurt(int amount)
    {
        stats.Health -= (Math.Abs(amount) - getDefense());
        if (stats.Health <= 0)
        {
            die();
        }
    }

    public void pickupItem(Item item)
    {
        item.holder = this;
        inventory.addItem(item);
    }

    protected void attack()
    {
        //Unarmed attacks!!        
        equippedWeapon.attack();
    }

    protected void castSpell(Spell spell)
    {
        if (stats.Mana > getSpellCost(spell)) spell.cast();
    }

    protected virtual Inventory die()
    {
        Destroy(this);
        return inventory;
    }

    protected void move(float xDir, float yDir)
    {
        Vector2 movement = new Vector2(xDir, yDir);
        position += Vector2.ClampMagnitude(movement, stats.MaxSpeed);
        rb.position = position;
    }

    protected int getDefense()
    {
        int def = 0;
        if (EquippedArmor != null)
        {
            def += EquippedArmor.defense;
        }

        //Add def modifiers in here eventually
        return def;
    }

    protected int getSpellCost(Spell spell)
    {
        //Add spell cost mods here
        return spell.Cost;
    }
}

