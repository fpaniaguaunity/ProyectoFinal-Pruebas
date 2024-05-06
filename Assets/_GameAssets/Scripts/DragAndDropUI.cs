using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragAndDropUI : MonoBehaviour, IDragHandler
{
    public bool selected = false;

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;
    }


}
