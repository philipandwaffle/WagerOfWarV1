using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopulateUI : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameEvents.events._onUnitClick += this.gameObject.GetComponent<UIController>().SetCurrentUnit;
    }
}
