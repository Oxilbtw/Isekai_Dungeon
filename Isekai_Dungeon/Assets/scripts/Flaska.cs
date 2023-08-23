using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Flaska : MonoBehaviour, ICollectible
{
    public static event HandleFlaskaCollected OnFlaskaCollected;
    public delegate void HandleFlaskaCollected(ItemData itemData);
    public ItemData flaskaData;

    public void Collect()
    {
        Destroy(gameObject);
        OnFlaskaCollected?.Invoke(flaskaData);
    }
}
