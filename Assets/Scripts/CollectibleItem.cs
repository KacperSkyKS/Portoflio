﻿using UnityEngine;
using System.Collections;
public class CollectibleItem : MonoBehaviour
{
    [SerializeField] private string itemName;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Managers.Inventory.AddItem(itemName);
            Destroy(this.gameObject);
        }
    }
}
