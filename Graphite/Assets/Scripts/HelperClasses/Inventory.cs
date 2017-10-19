using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Inventory
{
    private List<Item> items;

    public Inventory()
    {
        items = new List<Item>();        
    }

    public Inventory(List<Item> startingItems)
    {
        items = startingItems;
    }

    public Item removeItem(Item item)
    {
        items.Remove(item);

        return item;
    }

    public void addItem(Item item)
    {
        items.Add(item);
    }
}

