using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropManager : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        print(eventData.pointerDrag.transform.name);
        if (eventData.pointerDrag.transform.name == "ImageDraggeable")
        {
            print("Guay");
        }
        else
        {
            print("No guay");
        }
    }
}
