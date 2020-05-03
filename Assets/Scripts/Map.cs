using System.Collections.Generic;
using UnityEngine;

public class Map
{
    public int columns = 8;
    public int rows = 8;

    public Terrain[] terrain { get; set; }
    public Transform boardHolder { get; set; }
    public List<Vector3> gridPositions = new List<Vector3>();
}
