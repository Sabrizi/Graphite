using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class Weapon : Item, IEquipable
{
    public DamageRange damageRange;

    //public Weapon(DamageRange dr, int val = 0) : base(val)
    //{
    //    damageRange = dr;
    //}

    //public override void Awake()
    //{

    //}

    public void attack()
    {
        //Spawn equipped weapon hitbox
        //Run weapon animation
        //If weapon collides with a collider on the enemies layer
        //Hurt the creature (Or creatures???) the weapon collides with
    }

    public int getDamage()
    {
        return damageRange.getRoll() + holder.stats.Strength;
    }

    public void equip()
    {
        holder.EquippedWeapon = this;
    }

    //Do We want this? Allowing unequip allows for no weapon to be held.
    public void unequip()
    {
        //wielder.EquippedWeapon = null;
    }
}
