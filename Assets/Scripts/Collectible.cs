using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public CollectibleType type;
    void OnTriggerEnter2D(Collider2D collider)
    {
        Player player = collider.GetComponent<Player>();

        if (player != null)
        {
            player.numEggplantSeed++;
            Destroy(this.gameObject);
        }
    }
}

public enum CollectibleType
{
    NONE, EGGPLANT_SEED
}
