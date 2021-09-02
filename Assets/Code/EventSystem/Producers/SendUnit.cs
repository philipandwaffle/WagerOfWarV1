using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SendUnit : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            Unit u = gameObject.GetComponent<Unit>();
            if (u != null)
            {
                GameEvents.events.SetTargetUnit(u);
            }
        }
    }
}
