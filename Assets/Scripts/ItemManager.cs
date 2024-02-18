using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//
// Summary:
// Manages all collectible items in the game.
//
public class ItemManager : MonoBehaviour
{
    //
    // Summary:
    // An array of all collectible items in the game.
    //
    public Collectible[] collectables;

    // 
    // Summary:
    // A dictionary that contains all collectible items in the game.
    private  Dictionary<CollectibleType, Collectible> collectableItemDict = 
        new Dictionary<CollectibleType, Collectible>();
    
    private void Awake()
    {
        foreach (Collectible collectible in collectables)
        {
            AddItem(collectible);
        }
    }

    // 
    // Summary:
    // Add an item to the collectableItemDict.
    //
    private void AddItem(Collectible item)
    {
        if (!collectableItemDict.ContainsKey(item.type))
        {
            collectableItemDict.Add(item.type, item);
        }
    }

    //
    // Summary:
    // Return an item from the collectableItemDict by type.
    //
    public Collectible GetItemByType(CollectibleType type)
    {
        if (collectableItemDict.ContainsKey(type))
        {
            return collectableItemDict[type];
        }
        
        return null;
    }
}
