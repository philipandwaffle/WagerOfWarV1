using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class ClickEvent : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] public UnityEvent _onClick;
    [SerializeField] private bool _debug;
    public void OnPointerClick(PointerEventData eventData)
    {        
        _onClick.Invoke();
        if (_debug)
        {
            LogDebug();
        }
    }
    private void LogDebug()
    {
        Debug.Log($"Clicked on: {gameObject.name}");
    }
    public void SetEvent(UnityAction ua)
    {
        _onClick.AddListener(ua);
    }
}
