using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour {

    [SerializeField]
    private int gridWidth;
    [SerializeField]
    private int gridHeight;
    private Tile[,] grid;

	public void GenerateGrid()
    {
        grid = new Tile[gridWidth, gridHeight];
        for (int x = 0; x < gridWidth; x++)
        {
            for (int y = 0; y < gridHeight; y++)
            {
                grid[x, y] = GameObject.Instantiate(Services.Prefabs.Tile, 
                    Services.Main.transform).
                    GetComponent<Tile>();
                grid[x, y].Init(new Coord(x, y));
            }
        }
    }
}
