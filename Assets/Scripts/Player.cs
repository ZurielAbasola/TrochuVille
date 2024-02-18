using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 
// Summary: 
// The Player class is a MonoBehaviour that represents the player in the game.
//
public class Player : MonoBehaviour
{
    public Inventory inventory;

    public void Awake()
    {
        inventory = new Inventory(21);
    }

    // 
    // Summary:
    // Allow the player to drop an item from their inventory.
    //
    public void DropItem (Collectible item)
    {
        Vector3 spawnLocation = transform.position;

        Vector3 spawnOffset = Random.insideUnitCircle * 1.75f;

        Collectible droppedItem = Instantiate(item, spawnLocation + spawnOffset, Quaternion.identity);

        droppedItem.rb2d.AddForce(spawnOffset * .2f, ForceMode2D.Impulse);
    }
}
