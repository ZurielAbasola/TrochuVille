using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

// 
// Summary:
// Represents the UI for the player's inventory slots.
//
public class Slots_UI : MonoBehaviour
{
    public Image itemIcon;
    public TextMeshProUGUI quantityText;

    //
    // Summary:
    // Set the item icon and quantity text for the slot.
    //
    public void SetItem(Inventory.Slot slot) 
    {
        itemIcon.sprite = slot.icon;
        itemIcon.color = new Color(1, 1, 1, 1);
        quantityText.text = slot.count.ToString();
    }

    // 
    // Summary:
    // Set the item icon and quantity text for the slot to empty.
    //
    public void SetEmpty()
    {
        itemIcon.sprite = null;
        itemIcon.color = new Color(1, 1, 1, 0);
        quantityText.text = "";
    }
}
