using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class GameController : MonoBehaviour
{
    [SerializeField] public Board _board;

    [SerializeField] public GameObject riot;
    [SerializeField] public GameObject trooper;

    public void Start()
    {
        List<GameObject> riotCol = new List<GameObject> { riot, riot, riot, riot };
        List<GameObject> trooperCol = new List<GameObject> { trooper, trooper, trooper, trooper };
        List<GameObject> nullCol = new List<GameObject> { null, null, null, null };

        List<List<GameObject>> team = new List<List<GameObject>> { riotCol, trooperCol, nullCol };

        _board.PopulateBoard(team,team);
        _board.PlaceUnits();
    }
}
