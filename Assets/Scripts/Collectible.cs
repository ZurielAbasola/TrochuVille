using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 
// Summary:
// Represents a collectible item in the game.
//
public class Collectible : MonoBehaviour
{
    public CollectibleType type; 
    public Sprite icon;
    public Rigidbody2D rb2d;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // 
    // Summary:
    // Called when Player enters trigger collider to collect the item.
    //
    void OnTriggerEnter2D(Collider2D collider)
    {
        Player player = collider.GetComponent<Player>();

        if (player != null)
        {
            player.inventory.Add(this);
            Destroy(this.gameObject);
        }
    }
}

// 
// Summary:
// Represents the type of collectible item in the game.
//
public enum CollectibleType
{
    NONE, EGGPLANT_SEED
}
