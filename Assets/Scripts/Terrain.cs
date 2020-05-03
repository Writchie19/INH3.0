using UnityEngine;


/*
  - contains gameobject for single terrain
  - cost variable representing cost to move through
  - HP?
  - Cannot Move through some terrain?
 */
public class Terrain: MonoBehaviour
{
    public GameObject tile { get; set; }

    public Terrain(GameObject _tile)
    {
        this.tile = _tile;
    }
}
