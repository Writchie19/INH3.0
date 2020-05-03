using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//- BattleManager
//	- Tells MapManager what type of map to generate using String it was given by game manager
//	- Generate enemy units(Maybe given a string? or possibly enemy units already populated, GameManager would know context of situation) and place on map
//	- Begin player unit selection placement phase.
//	- Starts Turn Manager
//	- Display menu for player character, and handle player decision
//		- Move: 
//			- Display Moveable Locations
//			- Tell MapManager to move player to desired location (As long as the location is valid)
//		- Action:
//			- Attack:
//				- Show attack range? Depends on type of attack
//			- Dash:?
//			- Loot
//				- Chests
//				- fallen enemies?


public class BattleManager : MonoBehaviour
{
    private MapManager mapManager;
    public MapGenerator mapGenerator;
    public GameObject playerTile;

    public void StartLevel(string type)
    {
        mapManager.InitMap(type);
        mapManager.AddPlayer(new PlayerUnit(playerTile));
    }

    public void Init()
    {
        mapManager = gameObject.AddComponent<MapManager>();
        mapManager.mapGenerator = mapGenerator;
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
