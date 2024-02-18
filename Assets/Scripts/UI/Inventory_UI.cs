using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.SceneManagement;
using UnityEngine;

// 
// Summary:
// Represents the player's inventory in the game.
//
public class Inventory_UI : MonoBehaviour
{
    public GameObject inventoryPanel;
    public Player player;
    public List<Slots_UI> slots = new List<Slots_UI>();

    //
    // Summary:
    // Set the inventory panel to inactive when the game starts.
    //
    void Start()
    {
        inventoryPanel.SetActive(false);
    }

    // 
    // Summary:
    // When the player presses the tab key, toggle the inventory panel.
    //
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            TogleInventory();
        }
    }

    //
    // Summary:
    // Toggle the inventory panel on and off.
    //
    public void TogleInventory() 
    {
        if (!inventoryPanel.activeSelf) 
        {
            inventoryPanel.SetActive(true);
            Refresh(); 
        } 
        else
        {
            inventoryPanel.SetActive(false);
        }
    }

    //
    // Summary:
    // Refresh the inventory panel to display the current items in the player's inventory.
    //
    void Refresh() 
    {
        if (slots.Count == player.inventory.slots.Count) {
            for (int i = 0; i < slots.Count; i++) 
            {
                if (player.inventory.slots[i].type != CollectibleType.NONE)
                {
                    slots[i].SetItem(player.inventory.slots[i]);
                }
                else 
                {
                    slots[i].SetEmpty();
                }
            }
        }
    }

    // 
    // Summary:
    // Remove the item from the inventory slot and drop it on the ground.
    //
    public void Remove(int slotId)
    {
        Collectible itemToDrop = GameManager.instance.itemManager.GetItemByType(
            player.inventory.slots[slotId].type);

        if (itemToDrop != null)
        {
            player.DropItem(itemToDrop);
            player.inventory.Remove(slotId);
            Refresh();
        }
    }
}
