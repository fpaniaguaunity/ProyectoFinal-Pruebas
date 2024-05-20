using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemAlternativo : MonoBehaviour
{
    public string tagPlayer;
    public InventarioAlternativo inventarioAlternativo;  
    
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(tagPlayer))
        {
            inventarioAlternativo.NextItem();
            Destroy(gameObject);
        }
    }
}
