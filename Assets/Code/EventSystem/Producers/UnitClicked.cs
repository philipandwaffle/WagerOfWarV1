using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UnitClicked : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] public Unit _me;
    [SerializeField] private bool _debug;
    private void Start()
    {
        _me = gameObject.GetComponent<Unit>();
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        GameEvents.events.UnitClicked(_me);
        if (_debug)
        {
            LogDebug();
        }
    }
    private void LogDebug()
    {
        Debug.Log($"Clicked on: {gameObject.name}");
    }
}
