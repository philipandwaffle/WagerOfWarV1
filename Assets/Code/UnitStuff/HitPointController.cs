using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class HitPointController
{
    [SerializeField] public float _health;
    [SerializeField] public float _armour;
    [SerializeField] public float _modifier;
    [SerializeField] public bool _isDead = false;

    public HitPointController(float health, float armour = 0, float modifier = 0)
    {
        this._health = health;
        this._armour = armour;
        this._modifier = modifier;
    }

    public bool damage(float damage)
    {
        float d = damage;   //damage stored

        //unit has armour           
        if (_armour > 0)
        {
            _armour -= (1 - _modifier) * damage;  //apply damage to armour
            if (_armour < 0)
            {
                d = -_armour;    //negative armour it turned into carry over damage
                _armour = 0;     //armour is set to 0 so that armor is no longer applied
            }
        }
        _health -= d;        //apply damage to health
        _isDead = _health <= 0; //if the health is 0 or less then unit is dead
        if (_isDead)
        {
            _health = 0;
        }
        return _isDead;        //returns if the health is 0
    }
}
