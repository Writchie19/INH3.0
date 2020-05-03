using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//- MapManager
//	- Has a map generator
//		- Generate initial map given string
//	- Provides locations where player can place desired units at start of battle.
//	- Provides locations where enemies can be placed
//	- Has a MoveGenerator
//	- Handles generating all possible move locations for a particular character
//	- 


public class MapManager : MonoBehaviour
{
    public MapGenerator mapGenerator;
    private Map map;

    public void InitMap(string type)
    {
        map = mapGenerator.GenerateMap(type);
    }

    public void AddPlayer(PlayerUnit player)
    {
        GameObject instance = Instantiate(player.unitTile, new Vector3(0, 0, 0f), Quaternion.identity) as GameObject;
        instance.transform.SetParent(map.boardHolder);
    }

    private void Awake()
    {

    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
