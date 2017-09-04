using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour {
    
    public Coord coord { get; private set; }

	public void Init(Coord coord_)
    {
        coord = coord_;
        transform.position = new Vector3(coord.x, coord.y);
    }
}
