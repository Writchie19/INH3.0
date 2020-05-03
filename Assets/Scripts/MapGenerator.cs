using System.Collections.Generic;
using UnityEngine;


/*
 	- Holds all terrain game objects
	- Given String, generate random map
		- HashMap(Typeof Terrain) of List of lists of terrain gameobjects
			- Groups terrain gameobjects that go together in specific order
 */
public class MapGenerator : MonoBehaviour
{
    public GameObject[] tiles;
    private Map map = new Map();

    public Map GenerateMap(string type)
    {
        map.terrain = new Terrain[tiles.Length];

        for (int i = 0; i < tiles.Length; i++)
        {
            map.terrain[i] = new Terrain(tiles[i]);
        }

        InitialiseList();
        BoardSetup();
        return map;
    } 

    void InitialiseList()
    {
        map.gridPositions.Clear();

        for (int x = 1; x < map.columns - 1; x++)
        {
            for (int y = 1; y < map.rows - 1; y++)
            {
                map.gridPositions.Add(new Vector3(x, y, 0f));
            }
        }
    }

    void BoardSetup()
    {
        map.boardHolder = new GameObject("Board").transform;

        for (int x = -1; x < map.columns + 1; x++)
        {
            for (int y = -1; y < map.rows + 1; y++)
            {
                GameObject toInstantiate = map.terrain[Random.Range(0, map.terrain.Length)].tile;

                // This is for the outer tiles, may want to keep this for leater to keep player in bounds of game board
                if (x == -1 || x == map.columns || y == -1 || y == map.rows)
                {
                    //toInstantiate = outerWallTiles[]
                }

                GameObject instance = Instantiate(toInstantiate, new Vector3(x, y, 0f), Quaternion.identity) as GameObject;
                instance.transform.SetParent(map.boardHolder);
            }
        }
    }
}
