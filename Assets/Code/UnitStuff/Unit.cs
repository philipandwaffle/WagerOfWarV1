using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class Unit : MonoBehaviour
{
    [SerializeField] HealthBarController _healthBar;
    [SerializeField] public string _name;
    [SerializeField] public string _description;
    [SerializeField] public HitPointController _hitPointController;
    [SerializeField] public Attack[] _attacks;

    private void Start()
    {
        _healthBar.InitBar(_hitPointController._health, _hitPointController._armour);
    }

    public void Damage(float damage)
    {
        _hitPointController.damage(damage);
        _healthBar.UpdateBar(_hitPointController._health, _hitPointController._armour);
    }
}
