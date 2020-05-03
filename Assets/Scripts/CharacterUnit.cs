using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterUnit : MonoBehaviour
{
    public GameObject unitTile { get; set; }

    public CharacterUnit(GameObject _unitTile)
    {
        this.unitTile = _unitTile;
    }


}
