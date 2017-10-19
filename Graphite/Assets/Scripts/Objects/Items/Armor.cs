using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Armor : Item, IEquipable
{
    public int defense;

    //public Armor(int def, int val = 0) : base(val)
    //{

    //}

    //public override void Awake()
    //{
        
    //}

    public void equip()
    {
        holder.EquippedArmor = this;
    }

    public void unequip()
    {
        //throw new NotImplementedException();
    }
}

