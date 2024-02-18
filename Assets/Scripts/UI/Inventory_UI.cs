using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class Inventory_UI : MonoBehaviour
{
    public GameObject inventoryPanel;
    public Player player;
    public List<Slots_UI> slots = new List<Slots_UI>();

    void Start()
    {
        inventoryPanel.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            TogleInventory();
        }       
    }

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
}
