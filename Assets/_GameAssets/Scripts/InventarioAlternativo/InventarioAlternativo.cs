using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventarioAlternativo : MonoBehaviour
{
    Image[] images;
    private int currentItem = 0;
    void Start()
    {
        images = GetComponentsInChildren<Image>();
        ActivateItem();
    }
    public void NextItem()
    {
        currentItem++;
        ActivateItem();
    }
    private void ActivateItem()
    {
        for (int i=0;i<images.Length;i++){
            images[i].enabled = false;
        }
        images[currentItem].enabled = true;
        
    }
    
}
