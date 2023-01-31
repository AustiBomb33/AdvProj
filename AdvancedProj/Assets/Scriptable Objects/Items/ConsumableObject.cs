using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Consumable Object", menuName = "ScriptableObjects/Items/Consumable")]
public class ConsumableObject : ItemObject
{
    public void Awake()
    {
        type = ItemType.Consumable;
    }
}

