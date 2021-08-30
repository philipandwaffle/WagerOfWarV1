using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEvents : MonoBehaviour
{
    public static GameEvents events;
    // Start is called before the first frame update
    void Start()
    {
        events = this;    
    }

    public event Action<Unit> _onUnitClick;
    public void UnitClicked(Unit u)
    {
        _onUnitClick?.Invoke(u);
    }
}
