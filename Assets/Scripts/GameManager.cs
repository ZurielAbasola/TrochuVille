using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;

//
// Summary:
// A singleton class that manages the game state, 
// including the player's inventory and all collectible items in the game.
//
public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public ItemManager itemManager;

    //
    // Summary:
    // Awake is called when the script instance is being loaded.
    // This object will not be destroyed when loading a new scene.
    //
    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
        }

        //
        // Summary:
        // This object will not be destroyed when loading a new scene.
        //
        DontDestroyOnLoad(this.gameObject);

        itemManager = GetComponent<ItemManager>();
    }
}
