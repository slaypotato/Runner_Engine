using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    private int floorCounter = 0;

    public void setFloorCounter(int x)
    {
        floorCounter += x;
    }

    public int getFloorCounter()
    {
        return floorCounter;
    }
	
}
