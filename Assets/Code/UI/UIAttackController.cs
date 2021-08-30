using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIAttackController : MonoBehaviour
{
    [SerializeField] public Image _attackImage;
    [SerializeField] public Text _attackDetails;

    public void UpdateAttack(Attack a)
    {
        _attackImage = Resources.Load(a._sprite) as Image;
        _attackDetails.text = GenDetails(a);

    }
    private string GenDetails(Attack a)
    {
        string s = "";
        s += $"Name:\t\t\t{a._name}\n";
        s += $"Damage:\t\t{a._damage}\n";
        s += $"Attack Type:\t{a._type}\n";
        s += $"{a._description}";
        return s;
    }
}
