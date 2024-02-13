using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory
{
    public class Slot
    {
        public CollectibleType type;
        public int count;
        public int maxAllowed;

        public Slot()
        {
            type = CollectibleType.NONE;
            count = 0;
            maxAllowed = 99;
        }
    }

    public List<Slot> slots = new List<Slot>();

    public Inventory(int numSlots)
    {
        for (int i = 0; i < numSlots; i++)
        {
            Slot slot = new Slot();
            slots.Add(slot);
        }
    }

    public void Add(CollectibleType typeToAdd) 
    {
        foreach (Slot slot in slots)
        {
            if (slot.type == typeToAdd && )
        }
    }
}
