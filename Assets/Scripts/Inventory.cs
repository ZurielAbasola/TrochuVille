using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

// 
// Summary:
// Represents the player's inventory in the game.
//
[System.Serializable]
public class Inventory
{
    //
    // Summary:
    // Represents the type of collectible item in the game.
    //
    [System.Serializable]
    public class Slot
    {
        public CollectibleType type;
        public int count;
        public int maxAllowed;
        public Sprite icon;

        public Slot()
        {
            type = CollectibleType.NONE;
            count = 0;
            maxAllowed = 99;
        }

        // 
        // Summary:
        // Check if the slot can add an item.
        //
        public bool CanAddItem() {
            if (count < maxAllowed) 
            {
                return true;
            }

            return false;
        }

        // 
        // Summary:
        // Add an item to the slot.
        //
        public void AddItem(Collectible item) {
            this.type = item.type;
            this.icon = item.icon;
            count++;
        }

        // 
        // Summary:
        // Remove an item from the slot.
        //
        public void RemoveItem() 
        {
            if (count > 0)
            {
                count--;

                if (count == 0)
                {
                    type = CollectibleType.NONE;
                    icon = null;
                
                }
            }
        }
    }

    // 
    // Summary:
    // List of slots in the inventory.
    //
    public List<Slot> slots = new List<Slot>();

    public Inventory(int numSlots)
    {
        for (int i = 0; i < numSlots; i++)
        {
            Slot slot = new Slot();
            slots.Add(slot);
        }
    }

    //
    // Summary:
    // Add an item to the inventory.
    //
    public void Add(Collectible item) 
    {
        foreach (Slot slot in slots)
        {
            if (slot.type == item.type && slot.CanAddItem())
            {
                slot.AddItem(item);
                return;
            }
        }

        foreach (Slot slot in slots)
        {
            if(slot.type == CollectibleType.NONE)
            {
                slot.AddItem(item);
                return;
            }
        }
    }

    //
    // Summary:
    // Remove an item from the inventory.
    //
    public void Remove(int index)
    {
        slots[index].RemoveItem();
    }
}
