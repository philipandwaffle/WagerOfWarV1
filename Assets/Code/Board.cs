using System.Collections;
using System.Collections.Generic;
using UnityEngine;


class Board : MonoBehaviour
{
    public List<List<GameObject>> _team1;
    public List<List<GameObject>> _team2;
    [SerializeField] public float _spacing;
    [SerializeField] UIController _ui;

    private bool _isTeam1Turn = true;
    private Unit _selectedUnit;
    private Unit _targetedUnit;

    public void PopulateBoard(List<List<GameObject>> team1, List<List<GameObject>> team2)
    {
        this._team1 = team1;
        this._team2 = team2;
    }
        
    public void PlaceUnits()
    {
        List<List<GameObject>> board = new List<List<GameObject>>();
        for (int x = _team1.Count-1; x >= 0; x--)
        {
            board.Add(_team1[x]);
        }
        for (int x = 0; x < _team2.Count; x++)
        {
            board.Add(_team2[x]);
        }

        for (int x = 0; x < board.Count; x++)
        {
            for (int y = 0; y < board[x].Count; y++)
            {
                if (board[x][y] != null)
                {
                    board[x][y] = Instantiate(board[x][y]);
                    board[x][y].transform.Find("Sprite").GetComponent<ClickEvent>()._onClick.AddListener(delegate { _ui.SetCurrentUnit(board[x][y].GetComponent<Unit>()); });
                    board[x][y].transform.position = new Vector3(x * _spacing, y * _spacing, 0);
                    board[x][y].name = $"{x},{y}:\t{board[x][y].GetComponent<Unit>()._name}";
                }
            }
        }
    }

    public void SetSelected(Unit u)
    {
        this._selectedUnit = u;
    }
    public void SetTargeted(Unit u)
    {
        this._targetedUnit = u;
    }
}

